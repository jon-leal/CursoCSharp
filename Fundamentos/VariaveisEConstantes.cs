using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //area da circunferencia =    PI * raio * raio

            Console.Write("Digite o raio: ");
            double raio = Double.Parse(Console.ReadLine());

            //constante não pode ser alterada

            const double PI = 3.1416;

            double area = PI * raio * raio;

            Console.WriteLine("A area é " + area);

            //Tipos internos

            bool estaChovendo = true;

            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;

            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;

            Console.WriteLine("Saldo de gols " + saldoDeGols);

            short salario = short.MaxValue;

            Console.WriteLine("Salario " + salario);

            int menorValorInt = int.MinValue;

            Console.WriteLine("Menor valor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000; //sem sinal

            Console.WriteLine("População brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;

            Console.WriteLine("Menor valor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;

            Console.WriteLine("População mundial " + populacaoMundial);

            float precoComputador = 1299.99f;

            Console.WriteLine("Preço do computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00;

            Console.WriteLine("Valor de mercado da Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;

            Console.WriteLine("Distância entre estrelas " + distanciaEntreEstrelas);

            char letra = 'b';

            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao curso de C#";

            Console.WriteLine(texto);

        






    }

    }
}
