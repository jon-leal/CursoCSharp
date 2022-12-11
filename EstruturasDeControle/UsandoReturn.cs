using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class UsandoReturn
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        public static void Executar()
        {
            Console.WriteLine(Somar(1, 2));
            Console.WriteLine(Somar(3, 4));
            Console.WriteLine(Somar(5, 6));
        }
    }
}
