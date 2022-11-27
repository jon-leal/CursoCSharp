using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.Write("Digite a nota do aluno: ");
            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 9.0)
            {
                Console.WriteLine("Quadro de Honra!");
            }
            else if (nota >= 7.0) // Não precisa colocar >=7 && <9,
                                  // pois já foi verificado que é menor que 9.0
            {
                Console.WriteLine("Aprovado!");
            }
            else if (nota >= 5.0)
            {
                Console.WriteLine("Recuperação!");
            }
            else if (nota >= 3.0)
            {
                Console.WriteLine("Recuperação + Trabalho!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
            }

            Console.WriteLine("Fim!");
        }
    }
}
