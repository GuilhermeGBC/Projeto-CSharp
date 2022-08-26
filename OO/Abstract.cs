using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.OO
{

    public abstract class Celular
    {
        public abstract string Assistente();

        public string Tocar()
        {
            return string.Format("Trim trim trim...");
        }
    }
    public class Samsung : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Bixby!";
        }
    }
    public class Iphone : Celular
    {
        public override string Assistente()
        { //Sobrescrevemos o método numa classe filho pois na classe PAI o método é abstrato.
            return "Olá! Meu nome é Siri!";
        }
    }

    public class Abstract
    {

        public static void Executar()
        {
            //Celular celular1 = new Iphone();
            //Iphone IphoneX = new Iphone();
            //Console.WriteLine(IphoneX.Tocar());
            //Console.WriteLine(IphoneX.Assistente());

            var celulares = new List<Celular> { //Criando uma lista da CLASSE CELULAR QUE HERDA IPHONE E SAMSUNG.
                new Iphone(),
                new Samsung()

            };
            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
