using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.ClassesEMetodos {

    public class CarroOpcional {
        double desconto = 0.1; //Mesmo sem a palavra private, ele ainda é privado
        string nome; //nome privado e abaixo é publica, que vai armazenar os dados da publica na privada.
                     //É acessado diretamente pela propriedade public string Nome; GET PARA LER A PROPRIEDADE E SET PARA ALTERAR O VALOR DA PROPRIEDADE.
        public string Nome {
            get {
                return "Opcional: " + nome;
            }
            set {
                nome = value;
            }
        }


        // Propriedade autoimplementada
        public double Preco { get; set; }

        //Somente leitura
        public double PrecoComDesconto {
            get => Preco - (desconto * Preco); //Lambda
            //get {
            //    return Preco - (desconto * Preco);
            //}
        }
        public CarroOpcional() {

        }
        public CarroOpcional(string nome, double preco) {
            Nome = nome;
            Preco = preco; //Chama automaticamente o SET, ou this.nome para setar o atributo do objeto
        }
    }

    class Props {
        public static void Executar() {
            var op1 = new CarroOpcional("Ar Condicionado", 3499.9);
            Console.WriteLine(op1.PrecoComDesconto);

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2349.9;

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);
            Console.WriteLine("Preço com desconto: {0}", op1.PrecoComDesconto);
            
            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine("Preço com desconto {0}", op2.PrecoComDesconto);
        }
    }
}
