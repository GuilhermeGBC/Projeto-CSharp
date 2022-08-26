using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.ClassesEMetodos {
    class DesafioAtributo {
         int a = 10;         //ATRIBUTO PERTENCE A INSTÂNCIA
                             //DESAFIO ACESSAR A VARIÁVEL 'a' dentro do método Executar.
        public static void Executar() {      //Console.WriteLine(a); <- PRIMEIRO MÉTODO SE EU COLOCASSE "static int = 10;", porém não era desse jeito.

            // CRIAMOS UMA VARIÁVEL "inteiro" JUNTO DO NOME DA CLASSE EM QUE A VARIÁVEL INT ESTÁ DECLARADA "DesafioAtributo", SENDO ASSIM A VARIÁVEL QUE ATRIBUIMOS À CLASSE
            //DesafioAtributo, nos da acesso às variáveis dentro dela. Como o exemplo abaixo:
           
            DesafioAtributo inteiro = new DesafioAtributo(); 
            Console.WriteLine($"Imprimindo o resultado do desafio que é: {inteiro.a}"); 
        }    
    }
}
