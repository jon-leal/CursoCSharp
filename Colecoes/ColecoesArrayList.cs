using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CursoCSharp.Colecoes
{
    
    internal class ColecoesArrayList
    {
        public static void Executar()
        {
            var arrayList = new ArrayList // É uma coleção não genérica de objetos cujo tamanho aumenta dinamicamente.
                                          // É o mesmo que Array, exceto que seu tamanho aumenta dinamicamente.
                                          // Um ArrayList pode ser usado para adicionar dados desconhecidos onde você
                                          // não conhece os tipos e o tamanho dos dados.

            {
                "Palavra",
                3,
                true
            };

            arrayList.Add(3.14);

            foreach (var item in arrayList)
            {
                Console.WriteLine($"{item} => {item.GetType()}");
            }



            foreach (var item in arrayList)
            {

                if (item is int) // Verifica se o item é do tipo int

                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
