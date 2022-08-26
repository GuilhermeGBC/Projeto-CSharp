using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace ProjetoCSharp.API
{
    class ExemploDateTime
    {
        public static void Executar() {
            var dateTime = new DateTime(year: 2030, month: 2, day: 6); // Formato ano, mês e dia. Ou com parâmetros nomeados.
            

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            // Sem horas
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            //Com hora
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine("Hora: " + diaAtual.Hour);
            Console.WriteLine("Minutes: "+ diaAtual.Minute);

            var amanha = diaAtual.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine(ontem);

            Console.WriteLine(diaAtual.ToString("dd"));
            Console.WriteLine(diaAtual.ToString("d"));
            Console.WriteLine(diaAtual.ToString("D"));
            Console.WriteLine(diaAtual.ToString("dd/MM/yyyy HH:mm:ss"));


        }
    }
}
