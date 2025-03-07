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
    public partial class Form7: Form
    {
        function fn = new function();
        public Form7()
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
        // База данных запрос + dataGridView1
        private void Form7_Load(object sender, EventArgs e)
        {
            String query = "SELECT * FROM attendance";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        // Печатает таблицу из dataGridView1 (Print)
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        // Кнопка печать (Print)
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var f19 = new Form19();
            f19.Show();
            this.Hide();
        }
    }
}
