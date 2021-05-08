namespace SOLID.DIP.Viiolacao
{
    public class ClienteService
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.IsValid())
            {
                return "Dados inválidos!";

                /* Criando dependência com a Repository */
                var repo = new ClienteRepository();
                repo.AdicionarCliente(cliente);

                EmailService.Enviar("empresa@empresa.com.br", cliente.Email, "Bem vindo", "Cliente cadastrado com sucesso!");
                return "Cliente cadastrado com sucesso!";
            }
        }
    }
}