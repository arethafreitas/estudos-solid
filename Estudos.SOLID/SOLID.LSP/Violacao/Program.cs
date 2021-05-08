using System;

namespace SOLID.LSP.Violacao
{
    class Program
    {
        private static void ObterAreaRetangulo(Retangulo retangulo)
        {
            Console.WriteLine("Calculo da área do retângulo");
            Console.WriteLine(retangulo.Altura.ToString() + " * " + retangulo.Largura.ToString());
            Console.WriteLine(retangulo.Area);
            Console.ReadKey();
        }

        static void Main()
        {
            var quadrado = new Quadrado()
            {
                Altura = 10,
                Largura = 5
            };
            /* Deveria dar 50 porque está chamando o Retângulo, mas está dando 25 porque está sobrepondo o comportamento da classe base */
            ObterAreaRetangulo(quadrado);
        }
    }
}