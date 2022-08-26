using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.ClassesEMetodos {

    interface Ponto {
        void MoverNaDiagonal(int delta); // Não se pode colocar private para um método de interface e sim publico, mesmo que nao declare isso
    }
    
    struct Coordenada: Ponto { //Essa coordenada está aderente a essa interface, vou precisar definir o método mover na diagonal 
        public int X;
        public int Y;

        public Coordenada(int x, int y) { //Construtor recebe as variávei~s e suas declarações
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta) { //Métodos, atributos e comportamentos 
            X += delta;
            Y += delta; //Atribuição aditiva, estamos acrescentando valor nas variáveis X e Y.
        }
    }

     struct PessoaStruct
     {
       public string Nome;
       public int Idade;
       public double Altura;

        public PessoaStruct(string nome, int idade, double altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }

        
        public string ApresentarNoConsole()
        {
            return string.Format("");
        }
     }


    class ExemploStruct {
        public static void Executar() {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;
            Console.WriteLine("Coordenada Inicial:");
            Console.WriteLine("X = {0}", coordenadaInicial.X);
            Console.WriteLine("Y = {0}", coordenadaInicial.Y);

            var coordenadaFinal = new Coordenada(x: 9, y: 1); //podemos usar parâmetros nomeados que nem usamos aqui, mas podemos usar por exemplo passando apenas os valores(9, 1)
            coordenadaFinal.MoverNaDiagonal(10);

            Console.WriteLine("Coordenada Final:");
            Console.WriteLine("X = {0}", coordenadaFinal.X);
            Console.WriteLine("Y = {0}", coordenadaFinal.Y);


            PessoaStruct p1 = new PessoaStruct(); //Inicializando uma estrutura
            p1.Nome = "Anderson";
            p1.Idade = 22;
            p1.Altura = 1.75;

            PessoaStruct p2 = new PessoaStruct("Marcos", 19, 1.74);
            Console.WriteLine(p2.Nome);

            PessoaStruct p3 = new PessoaStruct()
            {
                Nome = "Arnaldo",
                Idade = 33,
                Altura = 1.82
            };

            p2 = p3;

            Console.WriteLine(p2.Nome);
            Console.WriteLine(p3.Nome);

            p3.Nome = "Guilherme";

            Console.WriteLine(p3.Nome);
            Console.WriteLine(p2.Nome);
        }
    }
}
