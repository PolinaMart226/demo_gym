using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_gym
{
    public partial class Form12 : Form
    {
        private readonly string connectionString = "Host=localhost;Database=dbgym;Username=postgres;Password=2264;Persist Security Info=True";
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // Загрузка данных в таблицу "dbgymDataSet.sessions"
            this.sessionsTableAdapter.Fill(this.dbgymDataSet.sessions);
            LoadDatesIntoComboBox(); // Вызов метода для загрузки дат в ComboBox
        }

        // Переход через кнопку Назад на форму 3 или Главная для администратора
        private void Button_back_Click(object sender, EventArgs e)
        {
            var f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        // Кнопка Показать список занятий
        private void Btn_Sessions_Click(object sender, EventArgs e)
        {
            // Получаем выбранную дату из comboBoxSessions и преобразуем в DateTime
            if (DateTime.TryParse(comboBoxSessions.SelectedItem.ToString(), out DateTime selecteddate))
            {
                LoadSessionsHistory(selecteddate);
            }
            else
            {
                MessageBox.Show("Выберите корректную дату.");
            }
        }
        private void LoadSessionsHistory(DateTime selecteddate)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT session_id, title, duration, trainer_id, max_participants " +
                                   "FROM sessions " +
                                   "WHERE date = @selecteddate";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("selecteddate", selecteddate); // Исправлено на "selecteddate"
                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable; // Предполагается, что у Вас есть DataGridView для отображения данных
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
        private void LoadDatesIntoComboBox()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT DISTINCT date FROM sessions ORDER BY date"; // Извлекаем уникальные даты

                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        comboBoxSessions.Items.Clear(); // Очищаем ComboBox перед добавлением новых значений
                        while (reader.Read())
                        {
                            DateTime date = reader.GetDateTime(0); // Получаем дату из результата запроса
                            comboBoxSessions.Items.Add(date.ToString("dd.MM.yyyy")); // Форматируем и добавляем в ComboBox
                        }
                    }
                }
            }
        }
        //Кнопка закрыть (Close)
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      // Переход через кнопку Назад на форму 3 или Главная для администратора
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
        // Печатает таблицу из dataGridView1 (Print)
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var f19 = new Form19();
            f19.Show();
            this.Hide();
        }
    }
}