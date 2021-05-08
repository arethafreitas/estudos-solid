using System;

namespace SOLID.ISP.Solucao
{
    public interface ICadastroCliente
    {
        void ValidarDados();
        void SalvarDados();
        void EnviarEmail();
    }
}
