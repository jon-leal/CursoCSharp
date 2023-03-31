using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2;

            Console.WriteLine(p1 == p2); // False
            Console.WriteLine(p3 == p2); // True

            Console.WriteLine(p1.Equals(p2)); // False - Por padrão, o método Equals compara referências de memória
            Console.WriteLine(p3.Equals(p2)); // True 

            // Para que o método Equals compare os valores dos atributos, é necessário sobrescrever o método Equals
            // e implementar a lógica de comparação
            // Adicionar as linhas 26 a 39 no código do snippet ColecoesList.cs
            //public override bool Equals(object obj)
            //{
            //    // Se o objeto for nulo ou não for do tipo Produto, retorna falso
            //    if (obj == null || !(obj is Produto))
            //    {
            //        return false;
            //    }

            //    // Converte o objeto para o tipo Produto
            //    var produto = (Produto)obj;

            //    // Retorna true se o nome e o preço forem iguais
            //    return Nome == produto.Nome && Preco == produto.Preco;
            //}
        }
    }
}
