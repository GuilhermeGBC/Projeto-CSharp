using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.OO
{
    sealed class SemFilho
    {
        public double ValorDaFortuna()
        {
            return 1_407_033.65;
        }
    }
    //class SouFilho : SemFilho {
    // Como a classe SemFilho é sealed não podemos herdá-la
    //}
    class Avo
    {
        public virtual bool HonrarNomeFamilia()
        { //Virtual permite que seja sobrescrito.
            return true;
        }
    }
    class Pai : Avo
    {
        public override sealed bool HonrarNomeFamilia()
        { //Junto com a sobrescrição selamos
            return true; //Obrigatoriamente todos que estão abaixo de Pai 
        }
    }
    class FilhoRebelde : Pai
    {
        //public new bool HonrarNomeFamilia() { //Com o new ocultamos o outro método sealed.
        //    return false;
        //}
    }
    class Sealed
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }
    }
}
