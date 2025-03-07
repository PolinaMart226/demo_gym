using System;
using System.Collections.Generic;
using Npgsql;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_gym
{
    public class PersonalData
    {
        public static int IdUser { get; private set; }
        public static string Password { get; private set; }
        public static string Login { get; private set; }
        public static string Role { get; private set; }

        public bool SetPersonalData(string login, string password)
        {
            // Обновлённая строка подключения для PostgreSQL
            string connectionString = "Host=localhost;Database=dbgym;Username=postgres;Password=2264;Persist Security Info=True";

            // Обновлённый SQL запрос
            string sqlExpression = "SELECT id_user, login, pass, role FROM public.users WHERE login = @Login AND pass = @Password";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(sqlExpression, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            IdUser = (int)reader["id_user"];
                            Role = reader["role"].ToString();
                            Login = reader["login"].ToString();
                            Password = reader["pass"].ToString();
                            return true;
                        }
                    }
                    return false;
                }
            }
        }
    }
}
