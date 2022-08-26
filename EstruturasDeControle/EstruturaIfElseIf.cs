using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.EstruturasDeControle {
    class EstruturaIfElseIf {
        public static void Executar() {
            
            Console.WriteLine("Digite a nota do aluno");
            string entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            if(nota >= 9.0) { //Se a nota for 9.0, vai pular todo o resto do código e irá para o final.
                Console.WriteLine("Quadro de Honra!"); // Se a nota não for 9.0, irá cair para o ELSE abaixo.
            } else if(nota >= 7.0) { //Fazendo um IF dentro do ELSE e irá testar a nota se é maior ou igual a 7.0 se a nota não entrou no >= 9.0, podemos tirar (&& nota < 9.0), pois sabemos que é menor do que 9.0
                Console.WriteLine("Aprovado!");
            } else if(nota >= 5.0) { // mesma coisa aqui, se não entrou no >= 7.0, sabemos que é <= 7.0
                Console.WriteLine("Recuperação!");
            } else {
                Console.WriteLine("Te vejo na proxima...");
            }
            Console.WriteLine("Fim!");
        }
    } /*RESUMINDO: SE O ALUNO TIROU NOTA 9 ELE VAI PRO QUADRO DE HONRA. 
       * SE TIROU ENTRE 7.0 A 8.9 ESTÁ APROVADO. 
       * ENTRE 5.0 A 6.9 ESTARÁ DE RECUPERAÇÃO.
       * SE TIROU ABAIXO DE 5.0 "TE VEJO NA PRÓXIMA".
      */
}
