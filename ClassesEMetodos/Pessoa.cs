using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome; // String tem padrão de inicialização null
        public int Idade; // Int tem padrão de inicialização 0

        public string Apresentar()
        {
            return string.Format($"Olá! Meu nome é {Nome} e tenho {Idade} anos."); 
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }

        public void Zerar()
        {
            Nome = "";
            Idade = 0;
        }
    }
}
