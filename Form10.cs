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
    public partial class Form10: Form
    {
        //Строка подключения к БД
        readonly function fn = new function();
        public Form10()
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
        //  База дынных, заполнение полей (поиск)
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int clientId = int.Parse(TxtClientId.Text.ToString());
            String query = "SELECT * FROM subscriptions WHERE client_id = " + clientId + "";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count != 0)
            {
                txtType.Text = ds.Tables[0].Rows[0]["type"].ToString();
                dtpStartDate.Value = DateTime.Parse(ds.Tables[0].Rows[0]["start_date"].ToString());
                dtpEndDate.Value = DateTime.Parse(ds.Tables[0].Rows[0]["end_date"].ToString());
                txtActive.Text = ds.Tables[0].Rows[0]["active"].ToString();
                txtPrice.Text = ds.Tables[0].Rows[0]["price"].ToString();
                txtStatus.Text = ds.Tables[0].Rows[0]["status"].ToString();
            }
            //  Неверный ID, ошибка
            else
            {
                MessageBox.Show("Неверный ID", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //  Кнопка Перезагрузить (Reset)
        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtClientId.Clear();
        }
        //  Кнопка Сохранить (Update-Save)
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            String query = "UPDATE subscriptions SET type='" + txtType.Text + "', start_date='" + dtpStartDate.Value.ToString("yyyy-MM-dd") + "', end_date='" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "', active='" + txtActive.Text + "', price=" + txtPrice.Text + ", status='" + txtStatus.Text + "', updated_at = CURRENT_TIMESTAMP WHERE client_id = " + TxtClientId.Text + "";
            fn.setDate(query);
            Form10_Load(this, null);
        }
        //  ClientId очистка рядом с поиском
        private void Form10_Load(object sender, EventArgs e)
        {
            TxtClientId.Clear();
        }
        // Очистка и перезагрузка полей
        private void TxtClientId_TextChanged(object sender, EventArgs e)
        {
            if (TxtClientId.Text == "")
            {
                txtType.Clear();
                dtpStartDate.ResetText();
                dtpEndDate.ResetText();
                txtActive.Clear();
                txtPrice.Clear();
                txtStatus.Clear();
            }
        }
    }
}
