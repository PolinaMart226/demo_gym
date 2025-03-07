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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Ввод правильных данных 
        private void Button_entrance_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var password = textBox2.Text;

            var PI = new PersonalData();
            if (PI.SetPersonalData(login, password))
            {
                var f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Пользователь не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Введите действительное имя пользователя или пароль", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Button_entrance.Enabled = false;
        }
        //Показывать пароль полностью или звездочки (Хеширование)
        private void BtnHideShow_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (BtnHideShow.Text == "Show")
            {
                BtnHideShow.Text = "Hide";
                textBox2.PasswordChar = '\0';
            }
            else
            {
                BtnHideShow.Text = "Show";
                textBox2.PasswordChar = '*';
            }
        }
        // Подверждение всех условий
        private void CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
            {
                Button_entrance.Enabled = true;
            }
            else
            {
                Button_entrance.Enabled = false;
            }
        }
        // Переход на форму 9. Регистрация пользователя
        private void button1_Click(object sender, EventArgs e)
        {
            var f9 = new Form9();
            f9.Show();
            this.Hide();
        }
    }
}
