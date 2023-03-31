using System;
using System.IO;

namespace CursoCSharp.Api
{
    class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDestino".ParseHome();
            var dirProjeto = @"~/source/repos/CursoCSharp".ParseHome();
            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true); // true para deletar subpastas
            }
            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true); // true para deletar subpastas
            }
            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));
            Console.WriteLine("== Pastas ==");
            var pastas = Directory.GetDirectories(dirProjeto);
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }
            Console.WriteLine("\n== Arquivos ==");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }
            Console.WriteLine("\n== Raízes ==");
            var raizes = Directory.GetLogicalDrives();
            foreach (var raiz in raizes)
            {
                Console.WriteLine(raiz);
            }
            Directory.Move(novoDir, novoDirDestino);
        }
    }
}
