using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class UsandoBreak
    {
        public static void Executar()
        {
            Random random = new Random(); // Random é uma classe que gera números aleatórios
            int numero = random.Next(1, 51); // Gera um número aleatório entre 1 e 50

            Console.WriteLine("O número que queremos é {0}", numero);

            for (int i = 1; i <= 50; i++)
            {
                Console.Write("{0} é o número que queremos? ", i);
                if (i == numero)
                {
                    Console.WriteLine("Sim!");
                    break; // O break sai do laço de repetição
                }
                else
                {
                    Console.WriteLine("Não!");
                }
            }

            Console.WriteLine("Fim!");
        }
    }
}
