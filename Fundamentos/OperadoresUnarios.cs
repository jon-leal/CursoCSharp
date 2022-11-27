using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var num1 = 2;
            var num2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); // 5, pois o valorNegativo é -5
            Console.WriteLine(!booleano); // false, pois o booleano é true

            num1++;
            Console.WriteLine(num1);

            --num1;
            Console.WriteLine(num1);

            Console.WriteLine(num1++ == --num2); // true, pois num1 é 2 e num2 é 2,
                                                 // pois num1 é incrementado depois da comparação
                                                 // e num2 é decrementado antes da comparação
            Console.WriteLine($"{num1} {num2}");
        }
    }
}
