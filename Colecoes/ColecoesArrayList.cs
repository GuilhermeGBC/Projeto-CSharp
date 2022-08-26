using System;
using System.Collections.Generic;
using System.Collections;

namespace ProjetoCSharp.Colecoes
{
    class ColecoesArrayList
    {
        public static void Executar() { //Estrutura que nao usa generics e sim apenas collections.
            var arraylist = new ArrayList
            {
                "Palavra",
                3,
                true,
                5000.00f,                
            };
            arraylist.Add(3.14);
            
            foreach (var item in arraylist)
            {
                Console.WriteLine("{0} => {1}", item, item.GetType()); //GetType nos mostra os tipos de dados que armazenamos;

            }
        }
    }
}
