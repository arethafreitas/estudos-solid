using System;

namespace SOLID.ISP
{
    public interface ICadastro
    {
        void ValidarDados();
        void SalvarDados();
        void EnviarEmail();
    }
}
