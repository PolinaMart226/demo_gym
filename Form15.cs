using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Npgsql;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_gym
{
    public partial class Form15: Form
    {
        // Строка подключения к БД
        private readonly string connectionString = "Host=localhost;Database=dbgym;Username=postgres;Password=2264;Persist Security Info=True";
        public Form15()
        {
            InitializeComponent();
            LoadTrainers();
        }
        private void LoadTrainers()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT trainer_id, name FROM public.trainers", connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Создаем объект Trainer и добавляем его в ComboBox
                        var trainer = new Trainer
                        {
                            Id = reader.GetInt32(0),
                            FullName = reader.GetString(1) // Предполагается, что имя уже в нужном формате
                        };
                        comboBox_Trainers.Items.Add(trainer);
                    }
                }
            }
        }

        // Класс для представления тренера
        private class Trainer
        {
            public int Id { get; set; }
            public string FullName { get; set; }

            public override string ToString()
            {
                return FullName; // Отображаем полное имя в ComboBox
            }
        }

        //Кнопка закрыть (Close)
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
        // Переход через кнопку Назад на форму 3 или Главная для администратора

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
        // Печатает таблицу из dataGridView1 (Print)
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView_Sessions.Width, this.dataGridView_Sessions.Height);
            dataGridView_Sessions.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView_Sessions.Width, this.dataGridView_Sessions.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        
        private void Btn_Subscriptions_Click(object sender, EventArgs e)
        {
            if (comboBox_Trainers.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите тренера.");
                return;
            }
            var selectedTrainer = (Trainer)comboBox_Trainers.SelectedItem;
            LoadSessions(selectedTrainer.Id);
        }
        private void LoadSessions(int trainerId)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT title, date, duration, max_participants FROM public.sessions WHERE trainer_id = @trainerId", connection))
                {
                    command.Parameters.AddWithValue("trainerId", trainerId);
                    using (var adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable sessionsTable = new DataTable();
                        adapter.Fill(sessionsTable);
                        dataGridView_Sessions.DataSource = sessionsTable;
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var f19 = new Form19();
            f19.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var f20 = new Form20();
            f20.Show();
            this.Hide();
        }
    }
}