using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.ClassesEMetodos {
    public class Dependente
    {
        public string Nome; //Classe
        public int Idade; //Struct
    }
    class ValorVsReferencia {
        public static void Executar() {
            int numero = 3;
            int copiaNumero = 3;
            Console.WriteLine($"{numero} {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dep = new Dependente
            {
                Nome = "Beto",
                Idade = 20
            };

            Dependente copiaDep = dep;
            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade} ");

            copiaDep.Nome = "Renato";
            dep.Idade = 21;
            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");
        }
    }
}
