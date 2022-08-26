using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.ClassesEMetodos {
    
    public enum Genero 
    { 
        Acao, Aventura, Terror, Animacao, Comedia, Romance
    }; //Não usamos nenhum tipo de acento nos itens de uma enumeração para evitar problemas

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }
      
    public enum Notas 
    {
        Minimo = 10,
        Media = 20,
        Maxima = 30 
    };

    
    class ExemploEnum {
        public static void Executar() {
            int id = (int)Genero.Aventura;  //Conversão de um Enum para inteiro, ter um número associado a aquele enum
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Sharknardo 17";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine("O filme {0} é de {1}", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);

            var filmeParaFamilia1 = new Filme();
            filmeParaFamilia1.Titulo = "Titanic";
            filmeParaFamilia1.GeneroDoFilme = Genero.Romance;

            Console.WriteLine("O filme {0} é de {1} com identificação {2}", filmeParaFamilia1.Titulo, filmeParaFamilia1.GeneroDoFilme, id);
            //---------------------------------------------------------------//------------------------------------------------------------//
            //ENUM DE NOTAS

            Notas Notas1 = Notas.Maxima;
                                        //Chamando o ENUM de NOTAS.
            Console.WriteLine(Notas1);
            Console.ReadKey();        
        }
    }    
}
