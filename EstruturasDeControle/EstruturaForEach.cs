using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "Opa!";

            foreach (var letra in palavra) // percorrer do primeiro ao último elemento da string
            {
                Console.WriteLine(letra); // imprime cada letra da string
            }

            var alunos = new string[] { "Ana", "Bia", "Carlos" };

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno); // imprime cada aluno do array
            }
        }
    }
}
