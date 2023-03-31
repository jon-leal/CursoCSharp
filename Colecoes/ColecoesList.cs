using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }



        //public override bool Equals(object obj) // (Exercicio Igualdade)
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

        public override int GetHashCode() // Não irá aceitar duplicidade (Exercício Igualdade GetHashCode)
        {
            return Nome.Length; 
        }
    }
    internal class ColecoesList
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new List<Produto>(); // List é uma classe genérica, <> é o tipo de dado que ela vai receber
            carrinho.Add(livro); // Adiciona um item na lista

            var combo = new List<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10),
                new Produto("Poster", 10), // Não irá aceitar duplicidade utilizando a linha 35 GetHashCode
            };

            carrinho.AddRange(combo); // Adiciona uma lista dentro de outra lista
            Console.WriteLine(carrinho.Count); // Quantidade de itens na lista 
            carrinho.RemoveAt(3); // Remove um item da lista pelo índice

            foreach (var item in carrinho) 
            {
                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}"); // Imprime o nome e o preço do item
            }

            Console.WriteLine(carrinho.Count); // Quantidade de itens na lista
            carrinho.Add(livro);
            Console.WriteLine(carrinho.LastIndexOf(livro)); // Retorna o índice do último item da lista
            Console.WriteLine(carrinho.Count);

            foreach (var item in carrinho)
            {
                Console.WriteLine($" {item.Nome}"); // Imprime o nome de todos os itens da lista
            }
        }
    }
}
