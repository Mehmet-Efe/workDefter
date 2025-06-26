namespace workDefter
{
    partial class loginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            mailInput = new TextBox();
            passwordInput = new TextBox();
            girisYap = new Button();
            kayitOl = new Button();
            label3 = new Label();
            errorMessageLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(110, 130);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "E-mail Adresi :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(157, 171);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Şifre :";
            // 
            // mailInput
            // 
            mailInput.Anchor = AnchorStyles.Top;
            mailInput.Location = new Point(199, 127);
            mailInput.Name = "mailInput";
            mailInput.Size = new Size(245, 23);
            mailInput.TabIndex = 2;
            // 
            // passwordInput
            // 
            passwordInput.Anchor = AnchorStyles.Top;
            passwordInput.Location = new Point(199, 168);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '•';
            passwordInput.Size = new Size(245, 23);
            passwordInput.TabIndex = 3;
            // 
            // girisYap
            // 
            girisYap.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            girisYap.Location = new Point(473, 357);
            girisYap.Name = "girisYap";
            girisYap.Size = new Size(75, 23);
            girisYap.TabIndex = 4;
            girisYap.Text = "Giriş Yap";
            girisYap.UseVisualStyleBackColor = true;
            girisYap.Click += girisYap_Click;
            // 
            // kayitOl
            // 
            kayitOl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kayitOl.Location = new Point(12, 357);
            kayitOl.Name = "kayitOl";
            kayitOl.Size = new Size(75, 23);
            kayitOl.TabIndex = 5;
            kayitOl.Text = "Kayıt Ol";
            kayitOl.UseVisualStyleBackColor = true;
            kayitOl.Click += kayitOl_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(106, 40);
            label3.Name = "label3";
            label3.Size = new Size(347, 56);
            label3.TabIndex = 6;
            label3.Text = "workDefter'e Hoşgeldiniz.\nSizi aramızda görmekten mutluyuz.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorMessageLabel
            // 
            errorMessageLabel.Anchor = AnchorStyles.Top;
            errorMessageLabel.AutoSize = true;
            errorMessageLabel.ForeColor = Color.Firebrick;
            errorMessageLabel.Location = new Point(263, 205);
            errorMessageLabel.Name = "errorMessageLabel";
            errorMessageLabel.Size = new Size(104, 15);
            errorMessageLabel.TabIndex = 7;
            errorMessageLabel.Text = "Hatalı Giriş Bilgisi !";
            errorMessageLabel.Visible = false;
            // 
            // loginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 392);
            Controls.Add(errorMessageLabel);
            Controls.Add(label3);
            Controls.Add(girisYap);
            Controls.Add(passwordInput);
            Controls.Add(mailInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(kayitOl);
            MinimumSize = new Size(370, 410);
            Name = "loginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Work Defter";
            Load += loginPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox mailInput;
        private TextBox passwordInput;
        private Button girisYap;
        private Button kayitOl;
        private Label label3;
        private Label errorMessageLabel;
    }
}
