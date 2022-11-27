using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElse
    {
        public static void Executar()
        {
            double nota = 7.0;

            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não fez mais que a obrigação!");
            }
            else
            { // o uso de {} pode ser omitido em else, mas é bom deixar para legibilidade
                Console.WriteLine("Recuperação!");
            }
        }
    }
}
