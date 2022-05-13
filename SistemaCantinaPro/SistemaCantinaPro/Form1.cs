using System.Data;

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
            string Conexao = "Server=50.62.209.50;Database;Uid=netinw;Psw" + txtPassWord + ";Ss1Mode=none";
            var connection = new MySqlConnection(Conexao);
            var command = connection.CreateCommand();
            MySqlConnection query = new MySqlConnection("select count(*) from Users where NomeUsuario = '" + 
                txtUserName.Text + "'and Senha '" + txtPassWord.Text + "'", connection);
            connection.Open();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.Fill(dataTable);

            foreach (DataRow dr in dataTable.Rows)
            {
                if(Convert.ToInt32(dr.ItemArray[0]) > 0)
                {
                    MessageBox.Show("User autentication sucessfully");
                }
                else
                {
                    MessageBox.Show("Invalid user", "Great" ,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }


            connection.Close();

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