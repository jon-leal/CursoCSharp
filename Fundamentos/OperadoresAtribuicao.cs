using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 = 7;
            num1 += 10; // num1 = num1 + 10;
            num1 -= 3; // num1 = num1 - 3;
            num1 *= 5; // num1 = num1 * 5;
            num1 /= 2; // num1 = num1 / 2;

            Console.WriteLine(num1);

            // Operadores de atribuição composta
            int a = 1;
            int b = a;

            // Operadores de atribuição composta
            a++; // a = a + 1;
            a--; // a = a - 1;

            // Pré-fixado
            --a;
            ++a;

            // Pós-fixado
            a++;
            a--;

            // Operadores de atribuição composta
            Console.WriteLine(a);
            Console.WriteLine(b);

            // Operadores de atribuição composta
            dynamic c = new System.Dynamic.ExpandoObject(); // cria um objeto dinâmico,
                                                            // sem tipo definido (não é recomendado)
            c.nome = "Maria";

            dynamic d = c;
            d.nome = "João"; // altera o nome do objeto c também

            Console.WriteLine(c.nome); // João, pois d é uma referência para c,
                                       // e não uma cópia, os dois compartilham o mesmo espaço na memoria
        }
    }
}
