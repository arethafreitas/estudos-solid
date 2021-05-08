namespace SOLID.DIP.Viiolacao
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clientRepository;
        private readonly IEmailService _emailService;

        public ClienteService(
            IClienteRepository clienteRepository,
            IEmailService emailService)
        {
            _clientRepository = clienteRepository;
            _emailService = emailService;
        }
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.IsValid())
            {
                return "Dados inválidos!";

                _clientRepositoryA.AdicionarCliente(cliente);
                
                _emailService.Enviar("empresa@empresa.com.br", cliente.Email, "Bem vindo", "Cliente cadastrado com sucesso!");
               
                return "Cliente cadastrado com sucesso!";
            }
        }
    }
}