using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.ClassesEMetodos 
{       
    class Params 
    {
        public static void Recepcionar(params string[] pessoas) {
            foreach (var pessoa in pessoas) {
                Console.WriteLine("Olá {0}", pessoa);
            }
        }
        public static void Idade(params int[] idades) {
            foreach(var idade in idades) {
                Console.WriteLine("{0} anos", idade);
            }
        }
        
        public static void Executar() {
            Recepcionar("Pedro", "Manu", "Roger", "Bia");
            Idade(18, 19, 20, 21);
        }
    }
}
