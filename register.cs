using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workDefter
{
    public partial class register : Form
    {
        dbConnection db;
        Form loginPage;
        public register(Form loginPage)
        {
            InitializeComponent();
            db = dbConnection.Instance;
            this.loginPage = loginPage;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (checkUserInfo())
            {
                db.yeniKullanici(
                    nameInput.Text.Trim(),
                    surnameInput.Text.Trim(),
                    mailInput.Text.Trim().ToLower(),
                    passwordInput.Text.Trim(),
                    birthDate.Value.Date
                );
                MessageBox.Show("Başarılı bir şekilde kayıt oldunuz!\nGiriş yapabilirsiniz.\nGiriş sayfasına yönlendirliyorsunuz.");
                this.Dispose();
                loginPage.Show();
            }
        }

        private bool checkUserInfo()
        {
            return isimKontrol() && mailKontrol() && sifreKontrol();
        }

        private bool mailKontrol()
        {
            if (string.IsNullOrWhiteSpace(mailInput.Text))
            {
                errorProvider.SetError(mailInput, "E-posta alanı boş bırakılamaz");
                return false;
            }

            if (!mailInput.Text.Contains("@") || !mailInput.Text.Contains(".com"))
            {
                errorProvider.SetError(mailInput, "Geçerli bir e-posta adresi girin");
                return false;
            }

            if (!db.mailKontrol(mailInput.Text.Trim()))
            {
                errorProvider.SetError(mailInput, "Bu e-posta adresi zaten kayıtlı");
                return false;
            }

            errorProvider.SetError(mailInput, "");
            return true;
        }

        private bool sifreKontrol()
        {
            if (string.IsNullOrWhiteSpace(passwordInput.Text))
            {
                errorProvider.SetError(passwordInput, "Şifre alanı boş bırakılamaz");
                return false;
            }

            if (passwordInput.Text.Length < 6)
            {
                errorProvider.SetError(passwordInput, "Şifre en az 6 karakter olmalıdır");
                return false;
            }

            if (string.IsNullOrWhiteSpace(passwordRepeat.Text))
            {
                errorProvider.SetError(passwordRepeat, "Şifre tekrar alanı boş bırakılamaz");
                return false;
            }

            if (passwordInput.Text != passwordRepeat.Text)
            {
                errorProvider.SetError(passwordRepeat, "Şifreler uyuşmuyor");
                return false;
            }

            errorProvider.SetError(passwordRepeat, "");
            return true;
        }

        private bool isimKontrol()
        {
            if (string.IsNullOrWhiteSpace(nameInput.Text))
            {
                errorProvider.SetError(nameInput, "Ad alanı boş bırakılamaz");
                return false;
            }
            else
            {
                errorProvider.SetError(nameInput, "");
            }

            if (string.IsNullOrWhiteSpace(surnameInput.Text))
            {
                errorProvider.SetError(surnameInput, "Soyad alanı boş bırakılamaz");
                return false;
            }
            else
            {
                errorProvider.SetError(surnameInput, "");
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            loginPage.Show();
        }
    }
}
