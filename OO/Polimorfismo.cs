using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.OO {

    public class Comida {
        public double Peso; //Uma vez que criarmos o método peso aqui, não precisamos mais dos outros.

        public Comida(double peso) { //Construtor
            Peso = peso;
        }

        public Comida() {

        }
    }

    public class Feijao : Comida{
        
    }

    public class Arroz : Comida { //Relações de herança entre as classes com a classe COMIDA.
        
    }

    public class Carne : Comida {
        
    }

    public class Pessoa {
        public double Peso;

        //public void Comer(Feijao feijao) //Pegar o valor do peso do feijão, arroz e carne e fazer uma atribuição aditiva no peso da pessoa.
        //{
        //    Peso += feijao.Peso;
        //}

        //public void Comer(Arroz arroz) {
        //    Peso += arroz.Peso;
        //}

        //public void Comer(Carne carne) {
        //    Peso += carne.Peso;
        //}
        public void Comer(Comida comida) { //Ao invés de 3 métodos, colocamos todos dentro de apenas um.
            Peso += comida.Peso;
        }

    }

    class Polimorfismo {
        public static void Executar() {
            Feijao ingrediente1 = new Feijao();
            ingrediente1.Peso = 0.3;

            Arroz ingrediente2 = new Arroz();
            ingrediente2.Peso = 0.25; //gramas

            Carne ingrediente3 = new Carne();
            ingrediente3.Peso = 0.3;

            Pessoa cliente = new Pessoa();
            cliente.Peso = 80.2;

            Console.WriteLine($"Peso inicial do cliente: {cliente.Peso}");

            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);

            Console.WriteLine($"Agora o peso do cliente é: {cliente.Peso}");

            
        }
    }
}
