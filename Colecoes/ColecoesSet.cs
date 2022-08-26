using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.Colecoes
{
    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of thrones", 49.9);

            var carrinho = new HashSet<Produto>(); //Ao contrário do list, colocamos hashset e perderemos algumas coisas, no caso coisas que são indexadas;
            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada Game o Thrones", 99.9), 
                new Produto("Poster", 10),
                new Produto("Poster", 10)
            };
            carrinho.UnionWith(combo); //Alterar o carrinho pra ser a união com o outro conjunto (combo)
            Console.WriteLine(carrinho.Count);           
            //carrinho.RemoveAt(3); 

            foreach (var item in carrinho)
            {
               // Console.Write(carrinho.IndexOf (item)); 
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }
            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
            // Console.WriteLine(carrinho.LastIndexOf(livro)); 

        }
    }
}
