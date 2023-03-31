using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    interface OperacaoBinaria // os métodos de uma interface são implícitos e públicos, não é necessário colocar public
    {
        int Operacao(int a, int b); // não é necessário colocar public, e nem o corpo do método (não é necessário colocar o return)
    }

    class Soma : OperacaoBinaria
    {
        public int Operacao(int a, int b) // não pode definir como protect, pois foi herdado como public da interface
        {
            return a + b;
        }
    }

    class Subtracao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
    }

    class Multiplicacao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }

    class Calculadora
    {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria> {
            new Soma(),
            new Subtracao(),
            new Multiplicacao()
        };

        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = "";

            foreach (var op in operacoes)
            {
                resultado +=
                    $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n";
            }

            return resultado;
        }
    }

    class Interface
    {
        public static void Executar()
        {
            var calc = new Calculadora();
            var resultado = calc.ExecutarOperacoes(20, 5);
            Console.WriteLine(resultado);
        }
    }
}
