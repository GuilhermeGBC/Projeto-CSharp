using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.Fundamentos 
{
    class Inferencia 
    {
        public static void Executar() {
            var nome = "Guilherme";
            Console.WriteLine(nome);
            //Detecção automatica do tipo de váriavel
            var idade = "18";
            Console.WriteLine(idade);

            //Declaração de variável 

            int a; // Declaração
            a = 3; // Inicialização

            //Declaração de variável com um valor inicial definido

            int b = 0;
            Console.WriteLine(a + b);

            


        }
    }
}
