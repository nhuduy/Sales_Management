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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Clicked(object sender, EventArgs e)
        {

        }

        private void btnClear_Clicked(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtFullname.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }
    }
}
