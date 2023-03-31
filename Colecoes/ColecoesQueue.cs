using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();
            fila.Enqueue("Fulano"); // Adiciona um item na fila
            fila.Enqueue("Ciclano");
            fila.Enqueue("Beltrano");
            fila.Enqueue("Sicrano");

            Console.WriteLine(fila.Peek()); // Retorna o primeiro item da fila
            Console.WriteLine(fila.Count); // Retorna a quantidade de itens na fila

            Console.WriteLine(fila.Dequeue()); // Remove o primeiro item da fila
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item")); // Verifica se o item existe na fila
            Console.WriteLine(salada.Contains("a")); // Verifica se o item existe na fila
            Console.WriteLine(salada.Peek()); // Retorna o primeiro item da fila
            Console.WriteLine(salada.Count); // Retorna a quantidade de itens na fila

            Console.WriteLine(salada.Dequeue()); // Remove o primeiro item da fila
            Console.WriteLine(salada.Count);

            foreach (var item in salada)
            {
                Console.WriteLine(item);
            }
        }
    }
}
