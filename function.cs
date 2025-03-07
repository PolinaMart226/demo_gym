using System;
using System.Data;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_gym
{
    class function
    {
        // Подключение PostgreSQL (БД) к проекту
        protected NpgsqlConnection getConnection()
        {
            NpgsqlConnection con = new NpgsqlConnection();
            // Строка подключения к базе данных PostgreSQL
            con.ConnectionString = "Host=localhost;Database=dbgym;Username=postgres;Password=2264;Persist Security Info=True";
            return con;
        }
        // Получение данных из БД для формы
        public DataSet getData(String query)
        {
            NpgsqlConnection con = getConnection(); // Получаем подключение
            NpgsqlCommand cmd = new NpgsqlCommand(); // Создаем команду
            cmd.Connection = con; // Устанавливаем соединение
            cmd.CommandText = query; // Устанавливаем текст команды
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd); // Создаем адаптер для заполнения DataSet
            DataSet ds = new DataSet(); // Создаем новый DataSet
            da.Fill(ds); // Заполняем DataSet данными
            return ds; // Возвращаем заполненный DataSet
        }

        public void setDate(String query) // Вставка, удаление и обновление данных
        {
            NpgsqlConnection con = getConnection(); // Получаем подключение
            NpgsqlCommand cmd = new NpgsqlCommand(); // Создаем команду
            cmd.Connection = con; // Устанавливаем соединение
            con.Open(); // Открываем соединение
            cmd.CommandText = query; // Устанавливаем текст команды
            cmd.ExecuteNonQuery(); // Выполняем команду (вставка, удаление, обновление)
            con.Close(); // Закрываем соединение
            MessageBox.Show("Данные успешно обработаны.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); // Сообщение об успешной обработке данных
        }
    }
}
