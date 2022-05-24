using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCantinaPro
{
    public partial class RegisterNewUserPage : Form
    {
        public RegisterNewUserPage()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> username = new List<string>();
            List<string> email = new List<string>();
            List<string> cellPhoneNumber = new List<string>();
            username.Add(txtName.Text);
            email.Add(txtEmail.Text);
            cellPhoneNumber.Add(txtNumPhone.Text);
            MessageBox.Show("You are singed in now", "Great, now you can Login");
        }

        
    }
}
