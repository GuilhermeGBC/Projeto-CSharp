using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.OO {
    public class Carro {
        protected readonly int VelocidadeMaxima; //Atributo somente leitura do tipo int.
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta) {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0) {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;
        }

        public virtual int Acelerar() //Virtual diz que esse método atual pode ser sobrescrito junto com o override em baixo.
        {
            return AlterarVelocidade(5); //Velocidade atual + 5
        }

        public int Frear() {
            return AlterarVelocidade(-5);
        }
    }
    public class Uno : Carro {
        public Uno() : base(200) { } //Caso não tenha um construtor base, podemos criar um assim. Construtor de UNO chamando o construtor BASE com o parâmetro que espera receber.

    }
    public class Ferrari : Carro {
        public Ferrari() : base(350) {

        }

        public override int Acelerar() { //Override para sobrescrever um método que foi definido na classe "pai".
            return AlterarVelocidade(15);
        }
        //Ocultar o método da classe PAI, no caso FREAR
        public new int Frear() {
            return AlterarVelocidade(-15); //Método que não usa override para "sobrescrever" um método.
        }
    }

    class Heranca {
        public static void Executar() {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar()); //Não altera os valores porque sobrescrevemos apenas na class Ferrari e não na Uno.
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari com tipo Carro...");
            Carro carro3 = new Ferrari(); //Para colocar o resultado que foi sobrescrito, devemos criar uma instância direto da classe PAI, "Carro"
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear()); //Freia -5 porque chama o método frear que está dentro da classe Carro e não Ferrari porque
            Console.WriteLine(carro3.Frear()); //Porque ocultamos o método da classe pai e não sobrescrevemos.
            Console.WriteLine(carro3.Frear());


            Console.WriteLine("Uno com tipo Carro...");
            carro3 = new Uno(); //Polimorfismo
            Console.WriteLine(carro3.Acelerar()); //Mesma variável assumindo múltiplas formas.
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());




        }
    }
}
