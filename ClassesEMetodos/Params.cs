using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Params
    {
        public static void Recepcionar(params string[] pessoas) // params permite que você passe um número variável de argumentos
        {
            foreach (var pessoa in pessoas) // irá percorrer o array de pessoas
            {
                Console.WriteLine("Olá {0}", pessoa); // e imprimir o nome de cada pessoa com a mensagem "Olá"
            }
        }

        public static void Executar()
        {
            Recepcionar("João", "Maria", "Pedro");
        }
    }
}
