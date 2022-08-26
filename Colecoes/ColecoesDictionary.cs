using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar() { //Dicionário de filmes, que vai armazenar o ano e o nome do filme.
            var filmes = new Dictionary<int, string>(); //Usando generic.

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004)) //Vai pegar o valor passado e verificar se está contido na coluna das chaves.
            {
                Console.WriteLine("2004: " + filmes[2004]); //Colchetes para pegar um valor de um dictionary.
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2008)); //Outra forma de pegar um dado, retorna o valor ou default.
            }
            Console.WriteLine(filmes.ContainsValue("Amnésia")); //Verificar se um determinado valor está contido dentro do array.
            
            //Método para remover, retorna verdadeiro ou false se conseguiu remover ou não. Se estava ou não presente no dictonary.
            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            //Método pegar valor.
            filmes.TryGetValue(2006, out string filme2006); //Mesmo que a chave não existe, não vai ter problema.
            Console.WriteLine($"Filme {filme2006}!!!");

            //Formas para percorrer um dictionary, percorrer só a chave, ou o valor e os dois.

            foreach (var chave in filmes.Keys) //Keys para os inteiros [CHAVE]
            {
                Console.WriteLine(chave);
            }
            //Apenas os valores(strings) [VALOR]
            foreach(var valor in filmes.Values)
            {
                Console.WriteLine(valor);
            }
            //Chave e valor ao mesmo tempo
            foreach(KeyValuePair<int, string>filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }

            //Deixando o próprio compilador inferir a variável( KeyValuePair)
            foreach(var filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }
        }
    }
}
