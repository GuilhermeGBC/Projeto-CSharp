using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class FilhoReconhecido : SubCelebridade
    { //Está próximo da subcelebridade
      //Como é herança não preciso criar uma instância de subcelebridade para acessar

        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoReconhecido...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);//Recebendo por herança e por ser do mesmo projeto.
            Console.WriteLine(NumeroCelular);//Dentro do mesmo projeto, internal.
            Console.WriteLine(JeitoDeFalar); //Herança.
            Console.WriteLine(SegredoFamilia);//Por herança mas precisa estar dentro do mesmo projeto.
            //Console.WriteLine(UsaMuitoPhotoshop); //Não vamos ter acesso pois o atributo é privado.
        }

    }
}
