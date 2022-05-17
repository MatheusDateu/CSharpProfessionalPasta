using System.Data;

namespace SistemaCantinaPro
{

    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }


        internal class Open
        {
            public static void openNew(Form one, Form two) { 
                one.Hide();
                two.Show();
            }
        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lkdClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dispose();
            Application.Exit();
            //Close();
            Environment.Exit(0);
        }

        private async void button1_Click(object sender, EventArgs e)
        {            
            String userName = txtUserName.Text;
            String passWord = txtPassWord.Text;
            if (userName == "" || passWord == "")
            {
                MessageBox.Show("Please insert user name and password to log", "Fields can not be null");
                return;
            }
            else if (userName != "Admin" || passWord != "1234")
            {
                MessageBox.Show("System could not match User with Password", "Somethins is wrong");
                return;
            }
            else
            {
                HomePage homePage = new HomePage();
                Open.openNew(this, homePage);
            }
                
        }
    }
}