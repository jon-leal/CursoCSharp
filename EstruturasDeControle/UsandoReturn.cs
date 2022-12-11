using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class UsandoReturn
    {
        public static int Somar(int a, int b) // Método que retorna um valor inteiro
        {
            return a + b; // return é uma palavra reservada que retorna um valor para o método
        }

        public static void Executar()
        {
            Console.WriteLine(Somar(1, 2)); // Irá imprimir 3
            Console.WriteLine(Somar(3, 4));
            Console.WriteLine(Somar(5, 6));
        }
    }
}
