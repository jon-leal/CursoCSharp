using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {
            double somatorio = 0;
            string entrada;

            Console.Write("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma); // out int tamanhoTurma = int.Parse(entrada);

            for (int i = 1; i <= tamanhoTurma; i++) // Ao invés de usar o while, podemos usar o for
                                                    // incluindo a variável de controle dentro do for
                                                    // com while seria necessário criar uma variável, depois 
                                                    // fazer a comparação e depois incrementar a variável
                                                    // i = 1
                                                    // while (i <= 10)
                                                    // { 
                                                    //      i++;
                                                    // }

            {
                Console.Write("Informe a nota do aluno {0}: ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAluno);
                somatorio += notaAluno;
            }

            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0; // Operador ternário, se tamanhoTurma for maior que 0, 
                                                                            // então media recebe somatorio/tamanhoTurma,
                                                                            // se não, recebe 0

            Console.WriteLine("Média da turma: {0}", media);

            // for (; media > 9 ; ) // Loop infinito
            // use o for quando souber o número de vezes que o loop será executado
            // use o while quando não souber o número de vezes que o loop será executado
            // use o switch quando tiver muitas comparações


        }
    }
}
