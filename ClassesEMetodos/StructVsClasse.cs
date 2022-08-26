using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.ClassesEMetodos {
    public struct SPonto {
        public int X;
        public int Y;
    }
    public class CPonto {
        public int X;
        public int Y;
    }
   
    class StructVsClasse 
    {
        public static void Executar() {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1; // ATRIBUIÇÃO POR VALOR, ou seja, uma cópia do valor do ponto1 é atribuida para variável copiaPonto1, podendo armazenar outro valor na variável ponto1.
            ponto1.X = 3; //Cópia por valor e não por referência           
            Console.WriteLine("Ponto 1 X: {0}", ponto1.X); //DESTA FORMA, SE TORNAM VALORES INDEPENDENTES, NÃO APONTAM PARA O MESMO LOCAL DE MEMÓRIA
            Console.WriteLine("Copia Ponto 1 X: {0}", copiaPonto1.X);
            
            
            SPonto ponto2 = new SPonto { X = 4, Y = 7 };
            SPonto copiaPonto2 = ponto2;
            ponto2.X = 7;
            Console.WriteLine("Ponto 2 X: {0}", ponto2.X);
            Console.WriteLine("Copia Ponto 2 X: {0}", copiaPonto2.X);
            //-----------------------------------//-----------------------------------//
            CPonto ponto3 = new CPonto { X = 2, Y = 4 };
            CPonto copiaPonto3 =  ponto3; //ATRIBUIÇÃO POR REFERÊNCIA!
            ponto3.X = 4; //APONTAM PARA O MESMO LOCAL DE MEMÓRIA, FAZENDO COM QUE OS RESULTADOS SEJAM OS MESMOS,ou seja, a partir de uma variável, o que eu alterar a outra variável vai enxergar pois elas apontam para o mesmo local, sendo assim, atribuição por referência.
            Console.WriteLine();
            Console.WriteLine("Ponto 3 X: {0}", ponto3.X);
            Console.WriteLine("Copia ponto 3: {0}", copiaPonto3.X);
        }
    }
}
