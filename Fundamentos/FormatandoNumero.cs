using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // 15.2 - 1 casa decimal
            Console.WriteLine(valor.ToString("C")); // R$ 15,18 currency
            Console.WriteLine(valor.ToString("P")); // 1517,50%  percentual
            Console.WriteLine(valor.ToString("#.##")); // 15,18 - 2 casas decimais

            CultureInfo cultura = new CultureInfo("en-US"); // Inglês EUA
            Console.WriteLine(valor.ToString("C3", cultura)); // US$ 15,175 currency 3 casas decimais

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // 0000000256 - 10 digitos
        }
    }
}
