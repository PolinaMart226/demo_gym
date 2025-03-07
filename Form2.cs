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
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            CheckRole(PersonalData.Role.ToUpper());
        }
        private string CheckRole(string role)
        {
            switch (role)
            {
                case ("КЛИЕНТ"):
                    Button_adm.Dispose();
                    Button_tr.Dispose();
                    MessageBox.Show($"Добро пожаловать {PersonalData.Login}", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return role;
                case ("АДМИНИСТРАТОР"):
                    Button_tr.Dispose();
                    Button_k.Dispose();
                    MessageBox.Show($"Добро пожаловать {PersonalData.Login}", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return role;
                case ("ТРЕНЕР"):
                    Button_adm.Dispose();
                    Button_k.Dispose();
                    MessageBox.Show($"Добро пожаловать {PersonalData.Login}", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return role;
                default:
                    Button_adm.Dispose();
                    Button_tr.Dispose();
                    Button_k.Dispose();
                    MessageBox.Show("Учетная запись некорректна.\rОбратитесь в тех. поддержку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return role;
            }
        }
        //Кнопки
        private void Button_back_Click(object sender, EventArgs e)
        {
            var f1 = new Form1();
            f1.Show();
            this.Hide();
        }
        private void Button_adm_Click(object sender, EventArgs e)
        {
            var f3 = new Form3();
            f3.Show();
            this.Hide();
        }
       
        private void Button_tr_Click(object sender, EventArgs e)
        {
            var f19 = new Form19();
            f19.Show();
            this.Hide();
        }

        private void Button_k_Click(object sender, EventArgs e)
        {
            var f20 = new Form20();
            f20.Show();
            this.Hide();
        }
    }
}
