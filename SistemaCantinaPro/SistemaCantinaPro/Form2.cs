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
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void lkdClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dispose();
            Application.Exit();
            //Close();
            Environment.Exit(0);
        }

        private void lkdNext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
