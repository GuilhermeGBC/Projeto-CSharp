using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.EstruturasDeControle {
    class UsandoBreak {
        public static void Executar() {
            
            Random random = new Random();
            int numero = random.Next(1, 51); //OBS: O NUMERO 1 ENTRA MAS O 51 NÃO, OU SEJA, DE  1 A 50.

            Console.WriteLine("O número que queremos é {0}", numero);

            for (int i = 1; i <= 50; i++) {
                Console.Write("{0} é o número que queremos?", i);
                if (i == numero) {
                    Console.WriteLine("Sim!");
                    break; //Caso o resultado seja encontrado, o break sai dessa sentença para a linha de código fora desse bloco FOR e não do IF.
                } else {
                    Console.WriteLine("Não!");
                }                   
            }
            Console.WriteLine("Fim!");
        }
    }
}
