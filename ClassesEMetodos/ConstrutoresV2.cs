using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.ClassesEMetodos
{
    class Carro {
        public string Fabricante;
        public string Modelo;
        public int Ano;

        public Carro(string fabricante, string modelo,  int ano) { //Parâmetros começam com as letras minúsculas e os atributos começam com maiúsculo.
            Fabricante = fabricante; //Atribuição passando do parâmetro para atributo com letra maiuscula
            Modelo = modelo; 
            Ano = ano;
        }
        public Carro() {

        }
        public string Apresentar() {
            return string.Format($"O fabricante é {Fabricante}, do modelo {Modelo} e do ano {Ano}");
        }
        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }        
    }
    
    class ConstrutoresV2 { 
    
        public static void Executar() {
            var carro1 = new Carro(); //Assim que criei o método acima, eu perco o construtor padrão
            carro1.Fabricante = "BMW"; //Quando criamos um construtor com parâmetros de entrada, perdemos o construtor padrão, mas com a criação de um novo com parâmetros vazios, conseguimos criar dessa forma.
            carro1.Modelo = "325i";
            carro1.Ano = 2017;
            carro1.ApresentarNoConsole();

            var carro2 = new Carro("Ford", "Ka", 2018); //Perdendo o construtor padrão, podemos passar os dados dessa forma e definir a ordem pelo retorno da string.
             //string.Format(
             //   $"O fabricante é {carro2.Fabricante}, do modelo {carro2.Modelo} e do ano {carro2.Ano}");
            carro2.ApresentarNoConsole();
            
            var carro3 = new Carro("Fiat", "Uno", 2007);
            carro3.ApresentarNoConsole();

            var carro4 = new Carro();
            carro4.Fabricante = "Fiat";
            carro4.Modelo = "Toro";
            carro4.Ano = 2020;
            carro4.ApresentarNoConsole();
        }
    }
}
