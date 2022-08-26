using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.ClassesEMetodos {
    class Carro1 {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro1(string modelo, string fabricante, int ano) {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro1() {

        }
    }

    class ConstrutoresV1 {
        public static void Executar() {
            var carro1 = new Carro1();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;
            
            Console.WriteLine(
                $"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            var carro2 = new Carro1("Ka", "Ford", 2018);
            Console.WriteLine(
                $"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            var carro3 = new Carro1() {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019
            };
            Console.WriteLine(
                $"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");
        }
    }
}


