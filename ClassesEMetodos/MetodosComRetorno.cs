using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComum
    {
        public int Somar(int a, int b) 
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Dividir(int a, int b)
        {
            return a / b;
        }
    }
    
    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this; // retorna a própria classe
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado()
        {
            return memoria;
        }
    }


    class MetodosComRetorno
    {
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public static void Executar() // void = sem retorno
        {
            //var calculadoraComum = new CalculadoraComum();
            //var resultado = calculadoraComum.Somar(5, 5);
            //Console.WriteLine(resultado);
            //Console.WriteLine(calculadoraComum.Subtrair(2, 7));
            //Console.WriteLine(calculadoraComum.Multiplicar(2, 5));
            //Console.WriteLine(calculadoraComum.Dividir(10, 2));

            //Console.WriteLine(Multiplicar(2, 2));
        
            var resultado = Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado); // Resultado: 4

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();
            // 9
            // 0
            
        }
    }
}
