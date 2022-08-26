using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.ClassesEMetodos {
    class Membros 
    {
        public static void Executar() {
            Pessoa sicrano = new Pessoa();  //Criando um objeto a partir dessa classe"sicrano"
            sicrano.Nome = "Renato";
            sicrano.Idade = 21;

           // Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";  //Como criamos um novo objeto, temos um novo nome e idade para armazenar independente da primeira instância "sicrano".
            fulano.Idade = 27;
            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano);
            //Console.WriteLine(apresentacaoDoFulano.Length); Nos mostra o tamanho da string.

            var beltrano = new Pessoa();
            beltrano.Nome = "Guilherme";
            beltrano.Idade = 19;
            beltrano.ApresentarNoConsole();
              //Exemplo de como podemos zerar os dados desse objeto.
            beltrano.ApresentarNoConsole();
            
            
            Pessoa beltrano1 = new Pessoa();
            beltrano1.Nome = "Marcos";
            beltrano1.Idade = 34;
            beltrano1.ApresentarNoConsole();

            Pessoa usuario = new Pessoa();
            usuario.Nome = "g ";
            usuario.Idade = 0;
            usuario.ApresentarNoConsole();


        }
    }
}
