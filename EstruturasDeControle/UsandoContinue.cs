using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.EstruturasDeControle {
    class UsandoContinue {
        public static void Executar() {
            int intervalo = 50;
            Console.WriteLine("Numeros pares entre 1 e {0}", intervalo);

            for (int i = 1; i <= intervalo; i++) { //Podemos também começar de 2 em 2, no caso mudariamos o valor da variável i para 2.
                if (i % 2 == 1) {   //Se o modulo da divisão por i, for igual a 1, quer dizer que o numero é impar e nao divisivel por 2.
                    continue;
                }
                Console.Write(i + " ");
            }

            for (int i = 2; i <= intervalo; i+= 2) { 
                if (i % 2 == 1) {   
                    continue;      //OUTRO METODO
                }
                Console.WriteLine(i + " ");
            }
        }
    }
}