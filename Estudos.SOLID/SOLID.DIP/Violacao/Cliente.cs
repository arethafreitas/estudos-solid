using System.Reflection.Metadata.Ecma335;
using System.Data;
using System;

namespace SOLID.DIP.Viiolacao
{
    public class Cliente
    {
        public string ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool isValid()
        {
            /* Criando dependência com acoplamento em duas classes */
            return EmailService.IsValid(Email) && CPFServices.IsValid(CPF);
        }
    }
}