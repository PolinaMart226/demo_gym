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
    public partial class Form4: Form
    {
        readonly function fn = new function();
        public Form4()
        {
            InitializeComponent();
        }
        //  При добавление клиента получается +1 к исходному числу каждый раз и отправляется в бд
        private void Form4_Load(object sender, EventArgs e)
        {
            String query = "SELECT MAX(client_id) FROM clients";
            DataSet ds = fn.getData(query);
            int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            labelNewID.Text = (count + 1).ToString();
        }
        //  Кнопка Перезагрузить. Очистка и перезагрузка полей (Reset)
        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtFIO_k.Clear();
            txtDOB_k.ResetText();
            txtAGE_k.Clear();
            txtAddress_k.Clear();
            txtMobile_k.Clear();
            txtEmail_k.Clear();
            MessageBox.Show("Данные успешно очищены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //  Кнопка Сохранить.Сохранение заполненных данных (Save)
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (txtFIO_k.Text != "" && txtDOB_k.Text != "" && txtAGE_k.Text != "" && txtAddress_k.Text != "" && txtMobile_k.Text != "" && txtEmail_k.Text != "")
            {
                String name = txtFIO_k.Text;
                String birthday = txtDOB_k.Text;
                String age = txtAGE_k.Text;
                String address = txtAddress_k.Text;
                String phone = txtMobile_k.Text;
                String email = txtEmail_k.Text;

                String query = "INSERT INTO clients (name, birthday, age, address, phone, email) VALUES ('" + name + "', '" + birthday + "', '" + age + "', '" + address + "', '" + phone + "', '" + email + "')";
                fn.setDate(query);
            }
            // Заполните все поля, ошибка 
            else
            {
                MessageBox.Show("Заполните все поля.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Кнопка Закрыть (Close)
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Кнопка Назад на общую форму
        private void Button_back_Click_1(object sender, EventArgs e)
        {
            var f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
