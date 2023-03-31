using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1;
        string nome;
        public string Nome
        {
            get
            {
                return "Opcional: " + nome;
            }
            set
            {
                nome = value;
            }
        }
        // propfull propriedade autoimplementada
        public double Preco { get; set; }
        // propriedade somente leitura
        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco);
        }
        public CarroOpcional()
        {

        }
        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public CarroOpcional(string nome) : this()
        {
            Nome = nome;
        }
        public CarroOpcional(double preco) : this()
        {
            Preco = preco;
        }
        public string Resumo()
        {
            return string.Format("{0} {1}", Nome, PrecoComDesconto);
        }
    }

    class Props
    {
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar Condicionado", 3499.9);
            Console.WriteLine(op1.Resumo());
            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2349.9;
            Console.WriteLine(op2.Resumo());
            var op3 = new CarroOpcional();
            op3.Nome = "Freio ABS";
            op3.Preco = 2349.9;
            Console.WriteLine(op3.Resumo());
            var op4 = new CarroOpcional();
            op4.Nome = "Ar Condicionado";
            op4.Preco = 2349.9;
            Console.WriteLine(op4.Resumo());
        }
    }


}
