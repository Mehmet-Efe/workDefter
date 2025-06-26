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
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(73, 131);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "E-mail Adresi :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(120, 172);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Şifre :";
            // 
            // mailInput
            // 
            mailInput.Anchor = AnchorStyles.Top;
            mailInput.Location = new Point(162, 128);
            mailInput.Name = "mailInput";
            mailInput.Size = new Size(245, 23);
            mailInput.TabIndex = 2;
            // 
            // passwordInput
            // 
            passwordInput.Anchor = AnchorStyles.Top;
            passwordInput.Location = new Point(162, 169);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '•';
            passwordInput.Size = new Size(245, 23);
            passwordInput.TabIndex = 3;
            // 
            // girisYap
            // 
            girisYap.Location = new Point(380, 408);
            girisYap.Name = "girisYap";
            girisYap.Size = new Size(75, 23);
            girisYap.TabIndex = 4;
            girisYap.Text = "Giriş Yap";
            girisYap.UseVisualStyleBackColor = true;
            girisYap.Click += girisYap_Click;
            // 
            // kayitOl
            // 
            kayitOl.Location = new Point(12, 408);
            kayitOl.Name = "kayitOl";
            kayitOl.Size = new Size(75, 23);
            kayitOl.TabIndex = 5;
            kayitOl.Text = "Kayıt Ol";
            kayitOl.UseVisualStyleBackColor = true;
            // 
            // loginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 443);
            Controls.Add(kayitOl);
            Controls.Add(girisYap);
            Controls.Add(passwordInput);
            Controls.Add(mailInput);
            Controls.Add(label2);
            Controls.Add(label1);
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
    }
}
