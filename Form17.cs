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
    public partial class Form17: Form
    {
        // Строка подключения к БД
        private readonly string connectionString = "Host=localhost;Database=dbgym;Username=postgres;Password=2264;Persist Security Info=True";
        public Form17()
        {
            InitializeComponent();
            LoadData();
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
        // Печатает таблицу из dataGridView1 (Print)
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView_Subscriptions.Width, this.dataGridView_Subscriptions.Height);
            dataGridView_Subscriptions.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView_Subscriptions.Width, this.dataGridView_Subscriptions.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        // Кнопка печать (Print)
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void LoadData()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM public.subscriptions";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView_Subscriptions.DataSource = dataTable;

                        // Подсчет общей суммы
                        decimal total = 0;
                        foreach (DataRow row in dataTable.Rows)
                        {
                            total += Convert.ToDecimal(row["price"]);
                        }
                        textBoxTotal.Text = total.ToString("C2"); // Форматирование как валюта
                    }
                }
            }
        }
    }
}
