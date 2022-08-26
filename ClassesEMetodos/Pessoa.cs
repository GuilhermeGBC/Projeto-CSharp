using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.ClassesEMetodos {
    class Pessoa 
    {
        public string Nome;
        public int Idade;
                                     //Dentro de apresentar, temos acesso as informações Nome e Idade por que está dentro da classe Pessoa.
        public string Apresentar() { //Sabemos que vai retornar uma string, mas precisa de um método de entrada? Não, porque quem é dono dos atributos é a classe Pessoa que tem acesso aos 2 métoddos.
            if (Nome == null || Idade <= 0 || Idade > 100) {
               return string.Format("Formato inválido, insira um nome e uma idade válidas!");
            } else {
                return string.Format(
                    $"Olá me chamo {Nome} e tenho {Idade} anos!");
            }
        }
        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar()); //Por que o texto formatado já está no método acima, "Apresentar" que vai pegar os atributos Nome e Idade vai formatar e retornar em string.
            
        }
        public void Zerar() {
            Nome = " ";
            Idade = 0;
        }
    }
}
