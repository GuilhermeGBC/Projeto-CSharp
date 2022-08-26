using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.Fundamentos 
{


    class Comentarios 
    {
         public static int x = 100;
         public static int y = 200;

        public static void Executar() {

             x = x + y; //300 //100 + 200
             y = x - y; //100 //300 - 200
             x = x - y; //200 //300 - 100

            Console.WriteLine(x);
            Console.WriteLine(y);

            // Para escrever comentários, mas cuidado com os desnecessários. 
            // Linguagens C, Java, JS, usam o padrão de comentários. 
            Console.WriteLine("Código claro é sempre melhor!");
            Console.WriteLine("O C# tem o XML Comments, com /// ");

        }
    }
}