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
using System.Globalization;

namespace demo_gym
{
    public partial class Form8 : Form
    {   //Строка подключения к БД
        private readonly string connectionString = "Host=localhost;Database=dbgym;Username=postgres;Password=2264;Persist Security Info=True";
        public Form8()
        {
            InitializeComponent();
        }
        //  Кнопка Закрыть (Close)
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
        //  Кнопка Сохранить (Save). Подключение,запрос к БД таблице + Параметризованный запрос 
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            // Проверка на корректность ввода данных
            if (string.IsNullOrWhiteSpace(txtClientId.Text) ||
                string.IsNullOrWhiteSpace(txtType.Text) ||
                string.IsNullOrWhiteSpace(txtActive.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtStatus.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            // Проверка на корректность цены
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Введите корректное значение цены.");
                return;
            }

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("INSERT INTO subscriptions (client_id, type, start_date, end_date, active, price, status) VALUES (@client_id, @type, @start_date, @end_date, @active, @price, @status)", connection))
                {
                    command.Parameters.AddWithValue("client_id", Convert.ToInt32(txtClientId.Text));
                    command.Parameters.AddWithValue("type", txtType.Text);
                    command.Parameters.AddWithValue("start_date", dtpStartDate.Value);
                    command.Parameters.AddWithValue("end_date", dtpEndDate.Value);
                    command.Parameters.AddWithValue("active", txtActive.Text);
                    command.Parameters.AddWithValue("price", price);
                    command.Parameters.AddWithValue("status", txtStatus.Text);

                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Абонемент добавлен успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //  Кнопка Перезагрузить. Очистка и перезагрузка полей (Reset)
        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtClientId.Clear();
            txtType.Clear();
            dtpStartDate.ResetText();
            dtpEndDate.ResetText();
            txtActive.Clear();
            txtPrice.Clear();
            txtStatus.Clear();
            MessageBox.Show("Данные успешно очищены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}