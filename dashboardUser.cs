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
    public partial class dashboardUser : Form
    {
        public userDetails currentUser;

        dbConnection db;
        public dashboardUser(userDetails user, Form anaUygulama)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void dashboardUser_Load(object sender, EventArgs e)
        {
            db = dbConnection.Instance;

            this.Text = "Dashboard - " + currentUser.Name;
        }
    }
}
