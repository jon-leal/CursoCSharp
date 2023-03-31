using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    delegate double Operacao(double x, double y); // delegate é um tipo de dado que representa um método
                                                  // que recebe dois doubles e retorna um double

    class LambdaDelegate
    {
        public static void Executar()
        {
            Operacao sum = (x, y) => x + y; // lambda é uma função anônima 
            Operacao sub = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;

            Console.WriteLine(sum(3, 3));
            Console.WriteLine(sub(5, 2));
            Console.WriteLine(mult(12, 8));
        }
    }
}