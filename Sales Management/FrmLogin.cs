using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales_Management
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Tester" && txtPassword.Text == "test")
            {
                MessageBox.Show("Login successful");
            }

            if (txtUsername.Text == "")
            {
                MessageBox.Show("Username can not empty");
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("Password can not empty");
            }

            this.Hide();
            FrmMain tomain = new FrmMain();
            tomain.ShowDialog();
        }
    }
}
