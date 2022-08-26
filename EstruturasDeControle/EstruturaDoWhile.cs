using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.EstruturasDeControle {
    class EstruturaDoWhile {
        public static void Executar() {
            string entrada;
            string entrada1; 

            do {
                Console.WriteLine("Digite seu nome: ");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem-vindo {0}", entrada);
                Console.WriteLine("Deseja continuar? (S/N)");
                entrada1 = Console.ReadLine();
            } while (entrada1.ToLower() == "s"); //Padronizamos para letra minúscula e comparamos para ver se digitou a letra "s".Caso seja a letra "s", significa que é verdadeira e vai continuar perguntando o nome.
        }                                       // Quantidade indeterminada de repetições
    }
}
