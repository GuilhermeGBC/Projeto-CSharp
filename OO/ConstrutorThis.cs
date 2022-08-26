using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.OO
{
    public class Animal
    {

        public string Nome { get; set; }

        public Animal(string nome)
        {
            Nome = nome;
        }
    }

    public class Cachorro : Animal
    { //Herda da classe Animal
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome)
        { //Nesse caso, quando o cachorro receber apenas o nome, vou querer chamar o construtor da classe PAI que quando não definimos um construtor, será chamado o construtor base que nao recebe nenhum parâmetro.
            Console.WriteLine($"Cachorro de {nome} inicializado");
        }
        //Segundo construtor
        public Cachorro(string nome, double altura) : this(nome)
        { //Chamando o construtor da própria classe com this e para o construtor da classe pai usamos base().
            Altura = altura;
        }
        //Converter um objeto para string com ToString.

        public override string ToString()
        {
            return $"{Nome} tem {Altura}cm de altura.".ToString(); //Método para transformar uma instância em uma string.
            //Para quando usarmos cachorro dentro de um contexto que é necessário string, ele vai chamar esse método que converterá para string.
        }
    }
    #region This
    class ConstrutorThis
    {
        public static void Executar()
        {
            var spike = new Cachorro("Spike");
            var max = new Cachorro("Max", 40.0);

            Console.WriteLine(spike); //Nesse contexto o objeto precisa ser transformado como string 
            Console.WriteLine(max);
        }
    }
    #endregion 

}
