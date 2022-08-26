using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2; //Atribuição por referência, ou seja, duas variáveis apontam para o mesmo local de memória.

            Console.WriteLine(p1 == p2); //Pergunta. Sim ou Não? Iguais ou diferentes?
            //Como criamos instâncias diferentes, eles criam outros espaços de memória...
            // que apontam para locais de memória diferentes.

            Console.WriteLine(p2 == p3); //True, pois p2 e p3 estão apontando para o mesmo local de memória.

            Console.WriteLine(p1.Equals(p2)); //Método para comparar endereços de memória
            //Definir se um determinado produto é igual ao produto 2.
        }
    }
}
