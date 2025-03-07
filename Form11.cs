using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Npgsql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_gym
{
    public partial class Form11 : Form
    {
        //Строка подключения к БД
        private readonly string connectionString = "Host=localhost;Database=dbgym;Username=postgres;Password=2264;Persist Security Info=True";
        public Form11()
        {
            InitializeComponent();
        }
        // Переход через кнопку Назад на форму 3 или Главная для администратора
        private void Button_back_Click(object sender, EventArgs e)
        {
            var f3 = new Form3();
            f3.Show();
            this.Hide();
        }
        //  Кнопка Закрыть (Close)
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Btn_Save_Click(object sender, EventArgs e)
        {
            await AddSessionAsync();
        }
        private async Task AddSessionAsync()
        {
            string title = txtTitle.Text;
            DateTime date = dtpDate.Value;
            int duration = (int)numDuration.Value;
            int maxParticipants = (int)numMaxParticipants.Value;

            // Пробуем преобразовать trainer_id из текста в integer
            if (!int.TryParse(txtTrainerId.Text, out int trainerId))
            {
                MessageBox.Show("Пожалуйста, введите корректный trainer_id.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var connection = new NpgsqlConnection(connectionString))
            {
                await connection.OpenAsync();
                string query = "INSERT INTO sessions (title,date, duration, trainer_id, max_participants) VALUES (@title, @date, @duration, @trainer_id, @max_participants)";

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("title", title);
                    command.Parameters.AddWithValue("date", date);
                    command.Parameters.AddWithValue("duration", duration);
                    command.Parameters.AddWithValue("trainer_id", (object)trainerId == null ? DBNull.Value : (object)trainerId);
                    command.Parameters.AddWithValue("max_participants", maxParticipants);

                    try
                    {
                        await command.ExecuteNonQueryAsync();
                        MessageBox.Show("Занятие успешно добавлено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при добавлении занятия: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        // Кнопка Перезагрузка и очистка полей
        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            dtpDate.ResetText();
            numDuration.ResetText();
            txtTrainerId.Clear();
            numMaxParticipants.ResetText();
            MessageBox.Show("Данные успешно очищены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
