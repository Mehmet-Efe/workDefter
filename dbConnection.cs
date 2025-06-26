using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workDefter
{
    sealed class dbConnection
    {

        private MySqlConnection con;
        private dbConnection()
        {
            const string _connectionString = "server=localhost; user=workdefter; database=workdefter; password=";

            con = new MySqlConnection(_connectionString);

            try
            {
                con.Open();
                Debug.WriteLine("Bağlantı Başarılı!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Veri tabanı bağlantısı başarısız!\n Hata: " + ex.Message);
            }

        }

        private static dbConnection _instance;

        private static readonly object _lock = new object();

        public static dbConnection Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new dbConnection();
                    }
                    return _instance;
                }
            }
        }

        public bool kullaniciKontrol(string mail, string sifre)
        {
            string query = "SELECT COUNT(*) FROM users WHERE mail = @mail AND password = @sifre";
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@mail", mail);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
    }
}
