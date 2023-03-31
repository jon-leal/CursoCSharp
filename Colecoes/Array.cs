using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5]; // Possui 5 posições no indentificador alunos
            alunos[0] = "Maria";
            alunos[1] = "Pedro";
            alunos[2] = "Ana";
            alunos[3] = "João";
            alunos[4] = "Rafael"; // Se tentar adicionar um 6º aluno, o programa irá dar erro

            foreach (var aluno in alunos) // "Para cada" aluno dentro do array alunos faça:
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0; // Somatório de notas
            double[] notas = { 9.7, 7.3, 6.5, 4.1 }; 

            foreach (var nota in notas)
            {
                somatorio += nota; // Somatório = somatório + nota
            }

            //for (int i = 0; i < alunos.Length; i++) // "Para" i = 0, enquanto i for menor que o tamanho do array alunos, faça:
            //{
            //    somatorio += notas[i]; // Somatório = somatório + nota[i]
            //}

            double media = somatorio / notas.Length; // Média = somatório / quantidade de notas
            Console.WriteLine($"Média da turma: {media}.");

            char[] letras = { 'A', 'B', 'C', 'D', 'E' };
            string palavra = new string(letras); // Transforma o array letras em uma string
            Console.WriteLine(palavra);
            Console.WriteLine(
                palavra[2]); // Mostra a letra que está na posição 2 do array letras

        }
    }
}
