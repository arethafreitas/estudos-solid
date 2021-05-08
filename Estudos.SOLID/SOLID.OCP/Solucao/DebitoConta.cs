using System.ComponentModel;
namespace SOLID.OCP.Solucao
{
    /*
    * Classe criada como abstract permitindo o override em classes externas 
    */
    public abstract class DebitoConta
    {
        public string NumeroTransacao { get; set; }
        public abstract string Debitar(decimal valor, string conta) { get; set; }
    }
}