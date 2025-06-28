namespace workDefter
{
    partial class dashboardUser
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
            panel1 = new Panel();
            label1 = new Label();
            surname = new Label();
            title = new Label();
            userName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(surname);
            panel1.Controls.Add(title);
            panel1.Controls.Add(userName);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 542);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.ControlText;
            label1.Location = new Point(19, 105);
            label1.Name = "label1";
            label1.Size = new Size(150, 1);
            label1.TabIndex = 2;
            // 
            // surname
            // 
            surname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            surname.Font = new Font("Segoe UI", 12F);
            surname.Location = new Point(0, 76);
            surname.Name = "surname";
            surname.Size = new Size(190, 20);
            surname.TabIndex = 1;
            surname.Text = "label1";
            surname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline);
            title.Location = new Point(12, 9);
            title.Name = "title";
            title.Size = new Size(165, 37);
            title.TabIndex = 1;
            title.Text = "workDefter";
            // 
            // userName
            // 
            userName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userName.Font = new Font("Segoe UI", 12F);
            userName.Location = new Point(0, 56);
            userName.Name = "userName";
            userName.Size = new Size(190, 20);
            userName.TabIndex = 0;
            userName.Text = "label1";
            userName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dashboardUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 542);
            Controls.Add(panel1);
            Name = "dashboardUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboardUser";
            Load += dashboardUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label title;
        private Label userName;
        private Label surname;
        private Label label1;
    }
}