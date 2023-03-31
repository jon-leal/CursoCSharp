using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class DelegatesComoParametros
    {
        public delegate int Operacao(int x, int y);
        public static int Soma(int x, int y)
        {
            return x + y;
        }
        public static string Calculadora(Operacao op, int x, int y)
        {
            var resultado = op(x, y);
            return "Resultado: " + resultado;
        }
        public static void Executar()
        {
            Operacao subtracao = (x, y) => x - y; // LÊ-SE: "subtração é uma função que recebe dois inteiros e retorna um inteiro"
            Console.WriteLine(Calculadora(subtracao, 3, 4));
            Console.WriteLine(Calculadora(Soma, 3, 4));
            Console.WriteLine(Calculadora((x, y) => x * y, 3, 4));
        }
    }
}
