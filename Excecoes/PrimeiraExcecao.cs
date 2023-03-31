using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
    public class Conta
    {
        double Saldo;

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo) 
            {
                throw new ArgumentException("Saldo insuficiente."); // Lançando uma exceção do tipo ArgumentException para o erro de saldo insuficiente
            }

            Saldo -= valor; // Atribuição de subtração
        }
    }

    class PrimeiraExcecao
    {
        public static void Executar()
        {
            var conta = new Conta(1_223.45);

            try // Quando utilizado um método que pode retornar erro, recomenda-se usar o método Try
            {
                // int.Parse("abc");

                conta.Sacar(1600);
                Console.WriteLine("Retirada com sucesso!");
            }
            catch (Exception ex) // somente erro do tipo ArgumentException será capturado se especificar ArgumentException
                                 // neste caso está sendo utilizado Exception como tipo genérico para capturar qualquer tipo de erro

            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message); // A mensagem é obtida de ArgumentException
            }
            finally // executado sempre, independente de erro ou não
            {
                Console.WriteLine("Obrigado!");
            }
        }
    }
}
