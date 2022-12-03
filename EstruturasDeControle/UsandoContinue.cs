using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class UsandoContinue
    {
        public static void Executar()
        {
            //int intervalo = int.TryParse(Console.ReadLine(), out intervalo) ? intervalo : 0; // Se o usuário digitar um número,
                                                                                               // o valor de intervalo será o número digitado,
                                                                                               // se não, será 0.

            int intervalo = 50;
            Console.WriteLine("Números pares entre 1 e {0}!", intervalo);

            for (int i = 1; i <= intervalo; i++)
            {
                if (i % 2 == 1) // Se o resto da divisão por 2 for 1, então é ímpar
                
                {
                    continue; // O continue pula para a próxima iteração do laço de repetição
                }

                Console.Write(i + " "); // Imprime o número par
                
            }

            //for (int i = 2; i <= intervalo; i += 2) // Outra forma de fazer o mesmo que o laço de repetição acima
            //{
            //    Console.Write(i + " ");
            //}
        }
    }
}
