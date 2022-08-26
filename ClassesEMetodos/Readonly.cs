using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.ClassesEMetodos 
{
    public class Cliente {
        public string Nome;
        public readonly DateTime Nascimento;  //Não pode ser declarado constante porque não tem um valor inicial definido, por isso podemos usar readonly que o torna imutável dentro do construtor.

        public Cliente(string nome, DateTime nascimento) {  //CONSTRUTOR
            Nome = nome;
            Nascimento = nascimento;

            Nascimento = new DateTime(2020, 10, 10); //Vai setar esse valor de datetime em todas instâncias, pois estamos colocando um "valor inicial" direto no construtor.
        }
        public string GetDataDeNascimento() {
            return String.Format("{0:D2}/{1:D2}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }

    class Readonly {
        public static void Executar() {  //Podemos trocar a ordem, ex: static public, só nao podemos mudar o lugar de void  pois mostra se vai retornar algo ou não.

            var NovoCliente = new Cliente("Ana Silva", new DateTime(1987, 05, 22));//Por conta do valor colocado dentro do construtor, não será exibido esse valor e sim o do construtor.
            Console.WriteLine(NovoCliente.Nome);
            Console.WriteLine(NovoCliente.GetDataDeNascimento());
            Console.WriteLine();
            var NovoCliente1 = new Cliente("Guilherme", new DateTime(2002, 07, 10));
            Console.WriteLine(NovoCliente1.Nome);
            Console.WriteLine(NovoCliente1.GetDataDeNascimento());
            Console.WriteLine();
           var NovoCliente2 = new Cliente ("Amanda", new DateTime(1997, 06 , 05));
            Console.WriteLine(NovoCliente2.Nome);
            Console.WriteLine(NovoCliente2.GetDataDeNascimento());


        }
    }
}
