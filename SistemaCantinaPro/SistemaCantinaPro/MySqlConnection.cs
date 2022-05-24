namespace SistemaCantinaPro
{
    internal class MySqlConnection
    {
        private string conexao;

        public MySqlConnection(string conexao)
        {
            this.conexao = conexao;
        }

        public MySqlConnection(string conexao, MySqlConnection connection)
        {
            this.conexao = conexao;
        }

        internal object CreateCommand()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            Close();
        }
    }
}