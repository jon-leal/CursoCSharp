﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CursoCSharp.Colecoes
{

    internal class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10),
                livro
            };

            carrinho.UnionWith(combo); // Adiciona os itens do combo ao carrinho
            Console.WriteLine(carrinho.Count);
            // carrinho.RemoveAt(3); // Remove o item do índice 3

            foreach (var item in carrinho)
            {
                // Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome}, {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro); // Não adiciona, pois já existe, não aceita duplicidade
            Console.WriteLine(carrinho.Count);
            // carrinho.Add(livro);
            // Console.WriteLine(carrinho.Count);
            // carrinho.Add(livro);
            // Console.WriteLine(carrinho.Count);
        }
    }
}


