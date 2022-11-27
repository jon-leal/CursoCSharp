using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.Write("Avalie meu atendimento com uma nota de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0: // não é necessário utilizar bloco de código {}
                    Console.WriteLine("Péssimo");
                    break; // break é necessário para sair do switch
                           
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Ótimo");
                    break;
                default: // default é opcional
                    Console.WriteLine("Nota inválida!");
                    break; 
            }

            Console.WriteLine("Obrigado pela avaliação!");
        }
    }
}
