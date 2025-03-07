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
    public partial class Form9: Form
    {   //Строка подключения к БД
        private readonly string connectionString = "Host=localhost;Database=dbgym;Username=postgres;Password=2264;Persist Security Info=True";
        public Form9()
        {
            InitializeComponent();
        }
        // Переход с помою кнопки Назад в форму 1, Вход
        private void Button_back_Click(object sender, EventArgs e)
        {
            var f1 = new Form1();
            f1.Show();
            this.Hide();
        }
        // Кнопка Закрыть (Close)
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Подключение к бд и таблице. Параметризованный запрос + уведомления, проверки 
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            // Проверка на заполненность всех полей
            if (string.IsNullOrWhiteSpace(txtid_user.Text) ||
                string.IsNullOrWhiteSpace(txtLogin.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtRole.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return; // Прерываем выполнение метода
            }

            // Проверка на корректность id_user
            if (!int.TryParse(txtid_user.Text, out int idUser))
            {
                MessageBox.Show("Введите корректный ID пользователя.");
                return; // Прерываем выполнение метода
            }

            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new NpgsqlCommand("INSERT INTO users (id_user,login, pass, role) VALUES (@id_user, @login, @pass, @role)", connection))
                    {
                        command.Parameters.AddWithValue("id_user", idUser);
                        command.Parameters.AddWithValue("login", txtLogin.Text);
                        command.Parameters.AddWithValue("pass", txtPassword.Text);
                        command.Parameters.AddWithValue("role", txtRole.Text);

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Пользователь добавлен успешно! Роль записана.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
        // Кнопка Перезагрузка и очистка полей
        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtid_user.Clear();
            txtLogin.Clear();
            txtPassword.Clear();
            txtRole.Clear();
            MessageBox.Show("Данные успешно очищены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}