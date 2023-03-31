using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    public static class ExtensoesInteiro
    {
        public static int Soma(this int num, int outroNumero)  // O uso de "this" demonstra que o método Soma é um método de extensão
        {
            return num + outroNumero; 
        }

        public static int Subtracao(this int num, int outroNumero)
        {
            return num - outroNumero;
        }
    }

    class MetodosDeExtensao
    {
        public static void Executar()
        {
            int numero = 5;

            Console.WriteLine(numero.Soma(3)); // Leia-se: Número (5) soma 3 (3) e retorna o resultado (8)
            Console.WriteLine(numero.Subtracao(10));

            Console.WriteLine(2.Soma(3));
            Console.WriteLine(2.Subtracao(4));
        }
    }
}
