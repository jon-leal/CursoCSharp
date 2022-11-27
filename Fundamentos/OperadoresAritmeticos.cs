using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            // Preço desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            double totalComDesconto = total - (total * desconto); // total * (1 - desconto)
            Console.WriteLine("O preço final é {0}", totalComDesconto); // O preço final é 935,5

            // IMC
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2); // Math.Pow(altura, 2) = altura * altura (Pow = Potência)
            Console.WriteLine("IMC é {0}", imc);

            // Número par/impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}
