using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.EstruturasDeControle {
    class EstruturaForEach {
        public static void Executar() {
            
            var palavra = "Olá!";     //Percorrer todas as letras de uma palavra
            foreach (var letra in palavra) { //Cada letra será atribuida a variável palavra
                Console.WriteLine(letra); //Percorrendo da primeira letra até a última
            }
            var alunos = new string[] { "Ana", "Bia", "Carlos" };
            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }

        }
    }
}
