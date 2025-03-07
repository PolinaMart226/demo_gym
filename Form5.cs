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
    public partial class Form5: Form
    {
        function fn = new function();
        public Form5()
        {
            InitializeComponent();
        }
        //  Кнопка Закрыть (Close)
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //  База дынных, заполнение полей (поиск)
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtClientID.Text.ToString());
            String query = "SELECT * FROM public.clients WHERE client_id = " + id + "";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count != 0)
            {
                txtFIO_k.Text = ds.Tables[0].Rows[0]["name"].ToString();
                txtDOB_k.Text = ds.Tables[0].Rows[0]["birthday"].ToString();
                txtAGE_k.Text = ds.Tables[0].Rows[0]["age"].ToString();
                txtAddress_k.Text = ds.Tables[0].Rows[0]["address"].ToString();
                txtMobile_k.Text = ds.Tables[0].Rows[0]["phone"].ToString();
                txtEmail_k.Text = ds.Tables[0].Rows[0]["email"].ToString();
            }
            //  Неверный ID, ошибка
            else
            {
                MessageBox.Show("Неверный ID", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //  Очистка и перезагрузка полей
        private void txtClientID_TextChanged(object sender, EventArgs e)
        {
            if (txtClientID.Text == "")
            {
                txtFIO_k.Clear(); 
                txtDOB_k.ResetText();
                txtAGE_k.Clear();
                txtAddress_k.Clear();
                txtMobile_k.Clear();
                txtEmail_k.Clear(); 
            }
        }
        //  Кнопка Перезагрузить (Reset)
        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtClientID.Clear();
        }
        //  Кнопка Сохранить (Update-Save)
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            String query = "UPDATE clients SET name='" + txtFIO_k.Text + "', birthday='" + txtDOB_k.Text + "', age='" + txtAGE_k.Text + "', address='" + txtAddress_k.Text + "', phone='" + txtMobile_k.Text + "', email='" + txtEmail_k.Text + "' WHERE client_id = " + txtClientID.Text + "";
            fn.setDate(query);
            Form5_Load(this, null);
        }
        //  ClientId очистка  рядом с поиском
        private void Form5_Load(object sender, EventArgs e)
        {
            txtClientID.Clear();
        }
        // Переход через кнопку Назад на форму 3 или Главная для администратора
        private void Button_back_Click(object sender, EventArgs e)
        {
            var f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
