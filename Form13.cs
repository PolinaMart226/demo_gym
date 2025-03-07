using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_gym
{
    public partial class Form13: Form
    {
        // Строка подключения к БД
        private readonly string connectionString = "Host=localhost;Database=dbgym;Username=postgres;Password=2264;Persist Security Info=True";
        public Form13()
        {
            InitializeComponent();
            numMaxParticipants.Minimum = 1; // Установка минимального значения для максимального количества участников
            numMaxParticipants.Maximum = 100; // Установка максимального значения
        }
        // Кнопка поиска
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string title = txtSearchTitle.Text;

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT session_id, date, duration, trainer_id, max_participants FROM public.sessions WHERE title = @title";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("title", title);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Заполнение полей данными из базы
                            SessionId.Text = reader["session_id"].ToString();
                            dtpDate.Value = (DateTime)reader["date"];
                            numDuration.Value = (int)reader["duration"];
                            txtTrainerId.Text = reader["trainer_id"].ToString();
                            numMaxParticipants.Value = (int)reader["max_participants"];
                        }
                        else
                        {
                            MessageBox.Show("Занятие не найдено.");
                        }
                    }
                }
            }
        }
        //Кнопка сохранения
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            int sessionId = int.Parse(SessionId.Text);
            DateTime date = dtpDate.Value;
            int duration = (int)numDuration.Value;
            int trainerId = int.Parse(txtTrainerId.Text);
            int maxParticipants = (int)numMaxParticipants.Value;

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE public.sessions SET date = @date, duration = @duration, trainer_id = @trainerId, max_participants = @maxParticipants WHERE session_id = @sessionId";
                using (var command = new NpgsqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("date", date);
                    command.Parameters.AddWithValue("duration", duration);
                    command.Parameters.AddWithValue("trainerId", trainerId);
                    command.Parameters.AddWithValue("maxParticipants", maxParticipants);
                    command.Parameters.AddWithValue("sessionId", sessionId);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Данные успешно обновлены.");
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при обновлении данных.");
                    }
                }
            }
        }
        // Кнопка перезагрузки и очистки полей
        private void BtnReset_Click(object sender, EventArgs e)
        {
            // Очистка полей
            txtSearchTitle.Clear();
            SessionId.Clear();
            dtpDate.Value = DateTime.Now;
            numDuration.Value = 0;
            txtTrainerId.Clear();
            numMaxParticipants.Value = 1; // Сброс к минимальному значению
        }
        // Кнопка закрыть (Close)
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Переход через кнопку Назад на форму 3 или Главная для администратора
        private void Button_back_Click(object sender, EventArgs e)
        {
            var f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
