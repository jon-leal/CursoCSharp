using System;
using System.IO;

namespace CursoCSharp.Api
{
    class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year: 2030, month: 2, day: 6);
            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            // Sem Horas
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            // Com Horas
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine("Hora: " + diaAtual.Hour);
            Console.WriteLine("Minuto: " + diaAtual.Minute);

            // Adicionar
            var amanha = diaAtual.AddDays(1);
            Console.WriteLine(amanha);
            Console.WriteLine(diaAtual.AddHours(5).AddMinutes(30));

            // Subtrair
            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine(ontem);
            Console.WriteLine(diaAtual.Subtract(TimeSpan.FromHours(2)));

            // String para DateTime
            Console.WriteLine(DateTime.Parse("2023-03-20"));
            Console.WriteLine(DateTime.Parse("20/03/2023"));

            // DateTime para String
            Console.WriteLine(diaAtual.ToString("dd"));
            Console.WriteLine(diaAtual.ToString("d"));
            Console.WriteLine(diaAtual.ToString("D"));
            Console.WriteLine(diaAtual.ToString("g"));
            Console.WriteLine(diaAtual.ToString("G"));
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm"));
        }
    }
}
