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
    public partial class Form20: Form
    {
        public Form20()
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

        private void Button1_Click(object sender, EventArgs e)
        {
            var f15 = new Form15();
            f15.Show();
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
