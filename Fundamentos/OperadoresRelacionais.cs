using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            // double nota = 6.0;
            // double notaDeCorte = 7.0;
            // 
            // Console.WriteLine("Nota inválida? {0}", nota > 10.0);
            // Console.WriteLine("Nota inválida? {0}", nota < 0.0);
            // Console.WriteLine("Perfeito? {0}", nota == 10.0);
            // Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
            // Console.WriteLine("Passou por média? {0}", nota >= notaDeCorte);
            // Console.WriteLine("Recuperação? {0}", nota < notaDeCorte);
            // Console.WriteLine("Reprovado? {0}", nota <= 3.0);

            Console.Write("Digite a primeira nota: ");
            double.TryParse(Console.ReadLine(), out double nota1);

            Console.Write("Digite a segunda nota: ");
            double.TryParse(Console.ReadLine(), out double nota2);

            double notaFinal = (nota1 + nota2) / 2;
            bool bomComportamento = true;
            double notaDeCorte = 7.0;
            bool alunoAprovado = notaFinal >= notaDeCorte;
            bool alunoRecuperacao = notaFinal < notaDeCorte && notaFinal >= 5.0;
            bool alunoReprovado = notaFinal < 5.0;
            string resultadoFinal = alunoAprovado ? "Aprovado" : alunoRecuperacao ? "Recuperação" : "Reprovado";
            // string resultadoFinal = alunoAprovado ? "Aprovado" : "Reprovado";
            // string resultadoFinal = alunoAprovado ? "Aprovado" : alunoReprovado ? "Reprovado" : "Recuperação";
            // string resultadoFinal = alunoAprovado ? "Aprovado" : alunoReprovado ? "Reprovado" : alunoRecuperacao ? "Recuperação" : "Indefinido";
            // string resultadoFinal = alunoAprovado ? "Aprovado" : alunoReprovado ? "Reprovado" : alunoRecuperacao ? "Recuperação" : bomComportamento ? "Indefinido" : "Indefinido";
            // string resultadoFinal =
        }

    }
}    