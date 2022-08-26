using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    public class SubCelebridade { //Não precisamos colocar o método Executar, pois será chamada no projeto principal.

        //Todos que tem acesso a classe podem acessar essa informação.
        public string InfoPublica = "Tenho um Instagram!";

        //Protected, que é transmitido por herança.
        protected string CorDoOlho = "Verde"; //Acessada caso seja herdado de SubCelebridade.

        //Mesmo projeto (assembly) OBS: Não entendi
        internal ulong NumeroCelular = 5511999999999; //Quem está dentro do mesmo projeto, tem acesso ao atributo do tipo internal.

        //Herança ou mesmo projeto, protected internal.
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        //Mesma classe ou herança no mesmo projeto (c# >= 7.2)
        private protected string SegredoFamilia = "Bla bla";

        //private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos() { //Método para mostrar tudo que podemos acessar dentro da classe SubCelebridade
            Console.WriteLine("SubCelebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);  //Conseguimos acessá-los por que todos esses atributos pertencem a própria classe.
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
