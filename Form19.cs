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
    public partial class Form19: Form
    {
        public Form19()
        {
            InitializeComponent();
        }
        //  Кнопка Закрыть (Close)
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Переход через кнопку Назад на форму 2 или Главная для всех
        private void Button_back_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            f2.Show();
            this.Hide();
        }
        // Переход на форму с кнопки Просмотр занятий, которые ведет конкретный тренер
        private void Button1_Click(object sender, EventArgs e)
        {
            var f15 = new Form15();
            f15.Show();
            this.Hide();
        }
        // Переход на форму с кнопки Список клиентов с истекшими абонементами
        private void Button7_Click(object sender, EventArgs e)
        {
            var f18 = new Form18();
            f18.Show();
            this.Hide();
        }
        // Переход на форму с кнопки Просмотр активных и истекших абонементов
        private void Button_Sub_Click(object sender, EventArgs e)
        {
            var f6 = new Form6();
            f6.Show();
            this.Hide();
        }
        // Переход на форму с кнопки Просмотр абонементов
        private void Btn_Subs_Click(object sender, EventArgs e)
        {
            var f6 = new Form6();
            f6.Show();
            this.Hide();
        }
        // Переход на форму с кнопки Просмотр посещений
        private void Btn_Att_Click(object sender, EventArgs e)
        {
            var f7 = new Form7();
            f7.Show();
            this.Hide();
        }
        // Переход на форму с кнопки Список занятий на определенную дату
        private void Button3_Click(object sender, EventArgs e)
        {
            var f12 = new Form12();
            f12.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
