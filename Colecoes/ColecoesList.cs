using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public override bool Equals(object obj)
        {
            Produto outroProduto = (Produto)obj; //Método para não comparar mais endereços de memória
            bool mesmoNome = Nome == outroProduto.Nome;
            bool mesmoPreco = Preco == outroProduto.Preco;
            return mesmoNome && mesmoPreco;    //Se tiverem o mesmo preço e o mesmo nome, serão verdadeiros.
        }
        public override int GetHashCode()
        {
            return Nome.Length; //Encontrou todos os itens que tem o mesmo HashCode, comparou com Equals e viu que é igual
                                //Entende que uma lsita não pode ter elementos iguais e não vai deixar adicionar elemento igual.
        }
    }
    
    class ColecoesList
    {
        public static void Executar()
        {
            var livro = new Produto("Game of thrones", 49.9);

            var carrinho = new List<Produto>(); //List usa using System.Collections.Generic; biblioteca que fica acima do namespace
            carrinho.Add(livro);

            var combo = new List<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada Game o Thrones", 99.9), //Criar uma lista já colocando os produtos diretamente na construção.
                new Produto("Poster", 10)
            };
            carrinho.AddRange(combo); //AddRange adiciona vários elementos de uma única vez, conteúdo de uma lista dentro de outra.
            Console.WriteLine(carrinho.Count); //Vai dizer quantos elementos possui o carrinho. Ver o tamanho da lista.           
            carrinho.RemoveAt(3); //Exemplo: remover o elemento de índice 3. 0, 1, 2, 3.

            foreach (var item in carrinho)
            {
                Console.Write(carrinho.IndexOf (item)); //IndexOf conta do zero, que nem quando aparece no console.
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }
            Console.WriteLine(carrinho.Count); //Verificar o tamanho da lsita antes de adicionar um item novo.
            carrinho.Add(livro);    //LIST ACEITA REPETIÇÃO, conseguimos adicionar dois elementos iguais
            Console.WriteLine(carrinho.LastIndexOf(livro)); // vai dizer qual o último índice desse elemento

        }
    }
}
