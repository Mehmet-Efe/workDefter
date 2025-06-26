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
            string qry = "SELECT COUNT(*) FROM users WHERE mail = @mail AND password = @sifre";
            using (MySqlCommand cmd = new MySqlCommand(qry, con))
            {
                cmd.Parameters.AddWithValue("@mail", mail);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public userDetails kullaniciGetir(string mail, string sifre)
        {
            string qry = "SELECT name, surname, mail, birthDate, userLevel FROM users WHERE mail = @mail AND password = @sifre";
            using (MySqlCommand cmd = new MySqlCommand(qry, con))
            {
                cmd.Parameters.AddWithValue("@mail", mail);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new userDetails(
                            reader.GetString("name"),
                            reader.GetString("surname"),
                            reader.GetString("mail"),
                            reader.GetDateTime("birthDate").ToString(),
                            reader.GetInt32("userLevel")
                        );
                    }
                }
            }
            return userDetails.deleteData();
        }

        public void yeniKullanici(String name, String surname, String mail, String password, DateTime birthDate)
        {
            string qry = "INSERT INTO users (name, surname, mail, password, birthDate) VALUES (@name, @surname, @mail, @password, @birthDate)";
            using (MySqlCommand cmd = new MySqlCommand(qry, con))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@surname", surname);
                cmd.Parameters.AddWithValue("@mail", mail);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@birthDate", birthDate);
                
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Kullanıcı kaydı başarısız!\n Hata: " + ex.Message);
                }
            }
        }

        public bool mailKontrol(string mail)
        {
            string qry = "SELECT COUNT(*) FROM users WHERE mail = @mail";
            using (MySqlCommand cmd = new MySqlCommand(qry, con))
            {
                cmd.Parameters.AddWithValue("@mail", mail.ToLower());
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                Debug.WriteLine($"Mail kontrolü: {mail} - {count} - {count == 0}");
                return count == 0;
            }
        }
    }
}
