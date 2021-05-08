using System.Reflection.Metadata.Ecma335;
using System.Data;
using System;

namespace SOLID.SRP.Violacao
{
    public class Cliente
    {
        public string ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }


        /*
        1ª Violação: Classe não deve ter responsabilidade de adicionar o cliente
        */
        public string AdicionarCliente()
        {
            /*
           2ª Violação: Classe não deve ter responsabilidade de validar as informações do cliente
           3ª Violação: Esse método não deve validar as 
           informações do cliente e também adicionar o cliente (2 responsabilidades no mesmo método)
           */
            if (!Email.Contains("@"))
                return "Cliente com e-mail inválido!";

            if (CPF.Length != 11)
                return "Cliente com CPF inválido!";

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