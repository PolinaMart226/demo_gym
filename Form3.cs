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
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        // Переход на форму с кнопки Добавить нового Клиента
        private void Button_adm_add_Click(object sender, EventArgs e)
        {
            var f4 = new Form4();
            f4.Show();
            this.Hide();
        }
        // Переход на форму с кнопки Редактировать Клиента
        private void Button_edit_Click(object sender, EventArgs e)
        {
            var f5 = new Form5();
            f5.Show();
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
        // Переход на форму с кнопки Добавить новый Абонемент
        private void Button_Subs_Click(object sender, EventArgs e)
        {
            var f8 = new Form8();
            f8.Show();
            this.Hide();
        }
        // Переход на форму с кнопки Просмотр активных и истекших абонементов
        private void Button_Sub_Click(object sender, EventArgs e)
        {
            var f6 = new Form6();
            f6.Show();
            this.Hide();
        }
        // Переход на форму с кнопки Редактировать Абонемент
        private void Button_red_subs_Click(object sender, EventArgs e)
        {
            var f10 = new Form10();
            f10.Show();
            this.Hide();
        }
        // Переход на форму с кнопки Добавить новое Занятие
        private void Btn_Sessions_Click(object sender, EventArgs e)
        {
            var f11 = new Form11();
            f11.Show();
            this.Hide();
        }
        // Переход на форму с кнопки Редактировать Занятие
        private void Btn_red_sessions_Click(object sender, EventArgs e)
        {
            var f13 = new Form13();
            f13.Show();
            this.Hide();
        }

        // Переход на форму с кнопки Назад на 1
        private void Button_back_Click(object sender, EventArgs e)
        {
            var f1 = new Form1();
            f1.Show();
            this.Hide();
        }
        // Переход на форму с кнопки Список занятий на определенную дату
        private void Button3_Click(object sender, EventArgs e)
        {
            var f12 = new Form12();
            f12.Show();
            this.Hide();
        }
        // Переход на форму с кнопки Добавление нового Тренера
        private void button4_Click(object sender, EventArgs e)
        {
            var f14 = new Form14();
            f14.Show();
            this.Hide();
        }
        // Переход на форму с кнопки Назначение тренеров на занятия
        private void button2_Click(object sender, EventArgs e)
        {
            var f11 = new Form11();
            f11.Show();
            this.Hide();
        }
        // Переход на форму с кнопки Просмотр занятий, которые ведет конкретный тренер
        private void button1_Click(object sender, EventArgs e)
        {
            var f15 = new Form15();
            f15.Show();
            this.Hide();
        }
        // Переход на форму с кнопки Отчет.Статистика по посещаемости
        private void button5_Click(object sender, EventArgs e)
        {
            var f16 = new Form16();
            f16.Show();
            this.Hide();
        }
        // Переход на форму с кнопки Отчеты по доходам от абонементов
        private void button6_Click(object sender, EventArgs e)
        {
            var f17 = new Form17();
            f17.Show();
            this.Hide();
        }
        // Переход на форму с кнопки Список клиентов с истекшими абонементами
        private void button7_Click(object sender, EventArgs e)
        {
            var f18 = new Form18();
            f18.Show();
            this.Hide();
        }
    }
}
