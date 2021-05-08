namespace SOLID.SRP.Solucao
{
    public class CPFService
    {
        public static bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}