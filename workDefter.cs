namespace workDefter
{
    public partial class loginPage : Form
    {

        dbConnection db;

        public loginPage()
        {
            InitializeComponent();
        }

        private void loginPage_Load(object sender, EventArgs e)
        {
            db = dbConnection.Instance;
        }

        private void girisYap_Click(object sender, EventArgs e)
        {
            string mail = mailInput.Text.Trim();
            string sifre = passwordInput.Text;
            if (db.kullaniciKontrol(mail,sifre))
            {
                
            }
            else
            {
                MessageBox.Show("Giriþ Baþarýsýz! Lütfen kullanýcý adý ve þifrenizi kontrol edin.");
            }
        }
    }
}
