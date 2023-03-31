using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class DesafioAtributo
    {
        int a = 10;

        public static void Executar()
        {
            // Resposta: Não é possível acessar um atributo não estático de uma classe estática.
            //Console.WriteLine(a); não compila

            DesafioAtributo desafio = new DesafioAtributo(); // instanciando a classe para acessar o atributo não estático "a"
            Console.WriteLine(desafio.a);
        }
    }
}
