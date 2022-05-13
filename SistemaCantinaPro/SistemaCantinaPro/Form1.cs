namespace SistemaCantinaPro
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            String userName = txtUserName.Text;
            String passWord = txtPassWord.Text;
            if (userName == "" || passWord == "")
            {
                MessageBox.Show("Please insert user name and password to log", "Fields can not be null");
                return;
            }
            else if (userName != "Matheus_Delmondes" || passWord != "p4ssw0rd")
            {
                MessageBox.Show("System could not match User with Password", "Somethins is wrong");
                return;
            }
            else
            {
                WelcomeScreen form = new WelcomeScreen();
                this.Visible = false;
                form.Show();
            }
        }
    }
}