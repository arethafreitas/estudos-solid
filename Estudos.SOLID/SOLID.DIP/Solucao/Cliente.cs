using System.Reflection.Metadata.Ecma335;
using System.Data;
using System;

namespace SOLID.DIP.Viiolacao
{
    private readonly ICPFService _cpfService;
     private readonly IEmailService _emailService;

        public Cliente(
            ICPFService cpfService,
            IEmailService emailService
        ) {
            _cpfService = cpfService;
            _emailService = emailService;

        }
    public class Cliente
    {
        public string ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool isValid()
        {
            return _emailService.IsValid(Email) && _cpfService.IsValid(CPF);
        }
    }
}