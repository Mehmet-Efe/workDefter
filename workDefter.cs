using Google.Protobuf.WellKnownTypes;

namespace workDefter
{
    public partial class loginPage : Form
    {

        dbConnection db;

        userDetails user;

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
            if (db.kullaniciKontrol(mail, sifre))
            {
                errorMessageLabel.Visible = false;
                user = db.kullaniciGetir(mail, sifre);
                dashboardUser dashboard = new dashboardUser(user, this);
                this.Hide();
                dashboard.FormClosed += (s, args) => this.Close();
                dashboard.Show();
            }
            else
            {
                errorMessageLabel.Visible = true;
            }
        }

        private void kayitOl_Click(object sender, EventArgs e)
        {
            register registerForm = new register(this);
            this.Hide();
            registerForm.FormClosed += (s, args) => this.Show();
            registerForm.Show();
        }
    }
}
