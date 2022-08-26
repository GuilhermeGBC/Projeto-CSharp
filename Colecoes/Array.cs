using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5]; //Um único identificador: alunos e é ele quem vai armazenar 5 valores,
            alunos[0] = "Anderson";                               //por que foi definido que o array tem o valor de 5, ou seja dentro da memória há 5 valores para 5 referências dentro de um único identificador.
            alunos[1] = "Bia";     //Estrutura indexada, acessada pelo índice
            alunos[2] = "Carlos";
            alunos[3] = "Daniela";    //Array de string
            alunos[4] = "Emanuel";
            
            
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };   //Array de nota
            
            foreach (var nota in notas)
            {
                somatorio += nota; //Adicionando as notas em somatorio
            }

            //for (int i = 0; i < notas.Length; i++) //Forma para acessar um array, mesma forma de fazer o método acima funcionar.
            //{
            //    somatorio += notas[i]; ESSE MÉTODO É A MESMA FORMA DO DE CIMA
            //}

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = {'A','r','r','a','y' }; //Char =  aspas simples.

            string palavra = new string(letras);
            Console.WriteLine(palavra);
            
             
            
        }
    }
}
