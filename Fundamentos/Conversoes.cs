using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado); // 10 - conversão implicita

            double nota = 9.7;
            // Cuidado com conversões!
            int notaTruncada = (int)nota; // 9 - conversão explicita, perde a parte decimal (casting)
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString); // conversão explicita, converte string para int
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString); // conversão explicita, converte string para int
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            Console.Write("Digite o primeiro número: "); // conversão mais segura
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1); // Irá converter a string para int,
                                                // se não conseguir, irá retornar 0

            Console.Write("Digite o segundo número: "); 
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Soma é: {0}", numero1 + numero2); // 0 + 0 = 0 (caso não tenha digitado nada
                                                                 // ou algo que não seja um número)

            Console.ReadLine();
        }
    }
}
