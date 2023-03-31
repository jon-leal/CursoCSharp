using System;
using System.IO;

namespace CursoCSharp.Api
{
    class ExemploFileInfo
    {
        public static void ExcluirSeExistir(params string[] caminhos) // params permite passar uma lista de argumentos
        {
            foreach (var caminho in caminhos)
            {
                FileInfo arquivo = new FileInfo(caminho);

                if (arquivo.Exists)
                {
                    arquivo.Delete();
                }
            }
        }

        public static void Executar()
        {
            var caminhoOrigem = @"~/exemplo_file_info.txt".ParseHome();
            var caminhoDestino = @"~/exemplo_file_info_DESTINO.txt".ParseHome();
            var caminhoCopia = @"~/exemplo_file_info_COPIA.txt".ParseHome();

            ExcluirSeExistir(caminhoOrigem, caminhoDestino, caminhoCopia);

            using (StreamWriter sw = File.CreateText(caminhoOrigem))
            {
                sw.WriteLine("Arquivo original!");
            }

            FileInfo origem = new FileInfo(caminhoOrigem); // FileInfo permite manipular arquivos e diretórios
            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.IsReadOnly);
            Console.WriteLine(origem.FullName);
            Console.WriteLine(origem.Extension);
            Console.WriteLine(origem.DirectoryName);

            origem.CopyTo(caminhoCopia);
            origem.MoveTo(caminhoDestino);
        }
    }
}
