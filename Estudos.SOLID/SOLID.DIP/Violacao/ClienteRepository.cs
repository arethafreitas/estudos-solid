namespace SOLID.DIP.Viiolacao
{
    public class ClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {
            using (var connection = new SqlConnection())
            {
                var cmd = new SqlCommand();

                connection.ConnectionString = "MinhaConexao";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Cliente (Nome, Email, CPF, DataCadastro) VALUES (@Nome, @Email, @CPF, @DataCadastro) ";

                cmd.Parameters.AddWithValue("Nome", Nome);
                cmd.Parameters.AddWithValue("Email", Email);
                cmd.Parameters.AddWithValue("CPF", CPF);
                cmd.Parameters.AddWithValue("DataCadastro", DataCadastro);

                connection.Open();
                cmd.ExecuteNonQuery();

            }
        }
    }
}