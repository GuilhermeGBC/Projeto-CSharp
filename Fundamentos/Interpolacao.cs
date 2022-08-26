using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.Fundamentos {
    class Interpolacao {
        public static void Executar() {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5900.00;
            //Concatenação, String concatenando com variável. String + variável + String + variável + String + variável, etc.
            Console.WriteLine("O "+ nome + " da marca " + marca + " custa " + preco + " reais.");
            
            //Alternativa de concatenação/ INTERPOLAÇÃO
            Console.WriteLine("O {1} da marca {1} custa {2}",
                nome, marca, preco);
           
            //Alternativa 3 começa com $"" e aa string entre {}
            Console.WriteLine($"A marca {marca}, é legal!");
            
            //Exemplo operação matemática com concatenação
            Console.WriteLine($"2 + 2 = {2 + 2}");



        }
    }
}
