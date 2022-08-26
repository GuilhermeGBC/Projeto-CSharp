using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class AmigoProximo
    {   //Instância para ter acesso aos atributos através de COMPOSIÇÃO.
        public readonly SubCelebridade amiga = new SubCelebridade();
        
        public void MeusAcessos()
        {
            Console.WriteLine("AmigoProximo...");
            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(CorDoOlho); Como foi marcado como protected é transmitido por herança e não por instância
            Console.WriteLine(amiga.NumeroCelular); //Protected internal
            Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(SegredoDeFamilia);
            //Console.WriteLine(amiga.UsaMuitoPhotoshop); PRIVADO.

        }
    }
}
