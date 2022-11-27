using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            //Simbolo operador ternário é o "?" (para condição) e ":" (para o else)
            //O operador ternário é uma forma de fazer uma estrutura de decisão.
            //Forma geral: condição ? verdadeiro : falso
            //             expressão   operando1   operando2
            //É uma forma de fazer um if e else de forma mais simples.

            var nota = 7.0;
            var bomComportamento = true;
            var resultado = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado"; // Operador Ternário, se nota for maior ou igual a 7.0
                                                                                        // e bomComportamento for true, resultado recebe
                                                                                        // "Aprovado", se não, recebe "Reprovado"
            Console.WriteLine(resultado);
        }
    }
}
