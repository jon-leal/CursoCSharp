using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            // Operadores lógicos
            // && - AND
            // || - OR
            // ^ - XOR
            // ! - NOT

            // Caso o trabalho na terça e quinta dê certo, comprar TV50 e sorvete
            // Caso o trabalho na terça ou quinta dê certo, comprar TV32 e sorvete

            /* Cenário TV50
              Ter | Qui | Sab
                 (And &&)
                V && V = V
                V && F = F
                F && V = F
                F && F = F
            
              Cenário Sorvete 
                  (Or ||)
              Ter | Qui | Sab
                V || V = V
                V || F = V
                F || V = V
                F || F = F
            
               Cenário TV32
                  (Xor ^)
               Ter | Qui | Sab
                 V ^ V = F
                 V ^ F = V
                 F ^ V = V
                 F ^ F = F
             */



            var executouTrabalho1 = false;
            var executouTrabalho2 = true;

            var comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a TV 50? {0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2; // ou exclusivo, um ou outro ou nenhum dos dois (XOR)
            Console.WriteLine("Comprou a TV 32? {0}", comprouTv32);

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete); // operador unário,negação lógica (NOT - !)
                                                                      // só tem um operando (não comprou sorvete) 
        }
    }
}
