namespace SOLID.DIP.Solucao.Interfaces
{
    public interface IEmailService
    {
         bool IsValid (string email);
         void Enviar(string from, string to, string subject, string message);
    }
}