using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random(); // Random é uma classe que gera números aleatórios
            int numeroSecreto = random.Next(1, 16); // Gera um número aleatório de 1 a 15

            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado) // 
            {
                Console.Write("Insira o seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.ForegroundColor; // Guarda a cor anterior
                    Console.ForegroundColor = ConsoleColor.Green; // Deixa a cor do texto verde
                    Console.WriteLine("Número encontrado em {0} tentativas!", tentativas);
                    Console.ForegroundColor = corAnterior;
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor... Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }
                else
                {
                    Console.WriteLine("Maior... Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }
            }
        }
    }
}
