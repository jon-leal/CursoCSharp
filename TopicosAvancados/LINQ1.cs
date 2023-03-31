using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    class LINQ1
    {
        public class Aluno
        {
            public string Nome; // Uso de ?Nome para que a variável Nome possa ser nula
            public int Idade;
            public double Nota;
        }

        public static void Executar()
        {
            var alunos = new List<Aluno>()
            {
                new Aluno() { Nome = "Pedro", Idade = 24, Nota = 8.0 },
                new Aluno() { Nome = "Andre", Idade = 21, Nota = 4.3 },
                new Aluno() { Nome = "Ana", Idade = 25, Nota = 9.5 },
                new Aluno() { Nome = "Jorge", Idade = 20, Nota = 8.5 },
                new Aluno() { Nome = "Ana", Idade = 21, Nota = 7.7 },
                new Aluno() { Nome = "Julia", Idade = 22, Nota = 7.5 },
                new Aluno() { Nome = "Marcio", Idade = 18, Nota = 6.8 },
            };
            Console.WriteLine("== Aprovados ===============");
            var aprovados = alunos.Where(a => a.Nota >= 7) // Para ordenar crescente basta utilizar OrderBy ou OrderBy(a => a.Nome)
                                  .OrderBy(a => a.Nome); // Para ordernar decrescente basta utilizar OrderByDescending ou a => -a.Nome

            foreach (var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nome);
            }
            Console.WriteLine("\n== Chamada ===============");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome); // Função Where (Filtro) e Select (Selecionar - Map)
            foreach (var aluno in chamada)
            {
                Console.WriteLine(aluno);
            }


            Console.WriteLine("\n== Aprovados (por Idade) ===============");
            var alunosAprovados = alunos.Where(a => a.Nota >= 7)
                                        .OrderBy(a => a.Idade);

            foreach (var aluno in alunosAprovados)
            {
                Console.WriteLine(aluno.Nome);
                //Console.WriteLine($"{aluno.Nome}  {aluno.Nota}");
            }


            Console.WriteLine("\nAprovados (por Idade):");
            var alunosAprovados2 = from aluno in alunos
                                   where aluno.Nota >= 7
                                   orderby aluno.Idade
                                   select aluno.Nome;
            foreach (var aluno in alunosAprovados2)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
