namespace workDefter
{
    partial class register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            registerButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            nameInput = new TextBox();
            surnameInput = new TextBox();
            mailInput = new TextBox();
            birthDate = new DateTimePicker();
            passwordInput = new MaskedTextBox();
            passwordRepeat = new MaskedTextBox();
            errorProvider = new ErrorProvider(components);
            label7 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // registerButton
            // 
            registerButton.Anchor = AnchorStyles.None;
            registerButton.Location = new Point(421, 357);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(75, 23);
            registerButton.TabIndex = 12;
            registerButton.Text = "Kayıt Ol";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(218, 97);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "İsim :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(199, 141);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyisim :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(170, 185);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 2;
            label3.Text = "E-mail Adresi :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(168, 229);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 3;
            label4.Text = "Doğum Tarihi :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(217, 273);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 4;
            label5.Text = "Şifre :";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(182, 317);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 5;
            label6.Text = "Şifre Tekrar :";
            // 
            // nameInput
            // 
            nameInput.Anchor = AnchorStyles.None;
            nameInput.Location = new Point(259, 93);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(237, 23);
            nameInput.TabIndex = 6;
            // 
            // surnameInput
            // 
            surnameInput.Anchor = AnchorStyles.None;
            surnameInput.Location = new Point(259, 137);
            surnameInput.Name = "surnameInput";
            surnameInput.Size = new Size(237, 23);
            surnameInput.TabIndex = 7;
            // 
            // mailInput
            // 
            mailInput.Anchor = AnchorStyles.None;
            mailInput.Location = new Point(259, 181);
            mailInput.Name = "mailInput";
            mailInput.Size = new Size(237, 23);
            mailInput.TabIndex = 8;
            // 
            // birthDate
            // 
            birthDate.Anchor = AnchorStyles.None;
            birthDate.Location = new Point(259, 225);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(237, 23);
            birthDate.TabIndex = 9;
            // 
            // passwordInput
            // 
            passwordInput.Anchor = AnchorStyles.None;
            passwordInput.Location = new Point(259, 269);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(237, 23);
            passwordInput.TabIndex = 10;
            // 
            // passwordRepeat
            // 
            passwordRepeat.Anchor = AnchorStyles.None;
            passwordRepeat.Location = new Point(259, 313);
            passwordRepeat.Name = "passwordRepeat";
            passwordRepeat.Size = new Size(237, 23);
            passwordRepeat.TabIndex = 11;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            label7.Location = new Point(114, 30);
            label7.Name = "label7";
            label7.Size = new Size(431, 37);
            label7.TabIndex = 13;
            label7.Text = "workDefter Üyeliğinizi Başlatın";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(340, 357);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Geri Dön";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 401);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(registerButton);
            Controls.Add(passwordRepeat);
            Controls.Add(passwordInput);
            Controls.Add(birthDate);
            Controls.Add(mailInput);
            Controls.Add(surnameInput);
            Controls.Add(nameInput);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new Size(450, 440);
            Name = "register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "workDefter - Kayıt Ol";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox nameInput;
        private TextBox surnameInput;
        private TextBox mailInput;
        private DateTimePicker birthDate;
        private MaskedTextBox passwordInput;
        private MaskedTextBox passwordRepeat;
        private ErrorProvider errorProvider;
        private Label label7;
        private Button button1;
    }
}