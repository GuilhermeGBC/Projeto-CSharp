using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.Fundamentos {
    class OperadoresAritmeticos {
        public static void Executar() 
        { // Preço com desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = (int) preco + imposto; // Operação de soma
            var totalComDesconto = total - (total * desconto); // Subtração e multiplicação, faz primeiro o que está entre aspas, primeiro multiplica depois subtrai
            Console.WriteLine("O valor final com desconto é {0} ", totalComDesconto); //para interpolar, nunca esquecer do {0}, {1}, {2}, etc.

            //  IMC

            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / (altura * altura); // Peso dividido pela altura² ou peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC é {imc}.");

            // Par e Impar

            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2); // resto da divisão de um valor impar por 2 é 1. um impar nao é divisivel por 2



        }
    }
}
