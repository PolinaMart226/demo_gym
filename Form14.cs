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
    public partial class Form14: Form
    {
        // Строка подключения к БД
        private readonly string connectionString = "Host=localhost;Database=dbgym;Username=postgres;Password=2264;Persist Security Info=True";
        public Form14()
        {
            InitializeComponent();
        }
        // Кнопка Закрыть (Close)
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Кнопка Назад на общую форму
        private void Button_back_Click(object sender, EventArgs e)
        {
            var f3 = new Form3();
            f3.Show();
            this.Hide();
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string email = EmailTextBox.Text;
            string phone = PhoneTextBox.Text;
            string specialization = SpecializationTextBox.Text;

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("INSERT INTO trainers (name, email, phone, specialization) VALUES (@name, @email, @phone, @specialization)", connection))
                {
                    command.Parameters.AddWithValue("name", name);
                    command.Parameters.AddWithValue("email", email);
                    command.Parameters.AddWithValue("phone", phone);
                    command.Parameters.AddWithValue("specialization", specialization);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Тренер успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при добавлении тренера: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            NameTextBox.Clear();
            EmailTextBox.Clear();
            PhoneTextBox.Clear();
            SpecializationTextBox.Clear();
        }
    }
}
