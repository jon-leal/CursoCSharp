using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    class Nullables
    {
        //int num3; // variável num3 será inicializada com 0 por padrão, fora do escopo de um método

        public static void Executar()
        {
            Nullable<int> num1 = null; // Forma antiga de declarar um nullable
            int? num2 = null; // Uso de ? para indicar que a variável pode ser nula
            //int num3; // variável num3 não pode ser inicializada sem valor, dentro do escopo de um método


            if (num1.HasValue)
            {
                Console.WriteLine("Valor de num: {0}", num1);
            }
            else
            {
                Console.WriteLine("A variável não possui valor.");
            }

            int valor = num1 ?? 1000; // Se num1 for nulo, atribui 1000 a variável valor utilizando o operador de coalescência nula
            Console.WriteLine(valor);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();
            Console.WriteLine(resultado);

            try
            {
                int x = num1.GetValueOrDefault();
                int y = num2.GetValueOrDefault();
                Console.WriteLine(x + y);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}