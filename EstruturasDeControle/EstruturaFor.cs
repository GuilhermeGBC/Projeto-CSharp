using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.EstruturasDeControle {
    class EstruturaFor {
        public static void Executar() {
                                   //ISTO É UMA FORMA DE DETERMINAR O NÚMERO DE REPETIÇÕES COM O WHILE.
            //int i = 1;
                               //Deixando dessa forma, se repetira por tempo indeterminado
            //while(i <= 10) {
            //    Console.WriteLine($"O valor de i é: {i}.");
            //    i++; //Incrementamos o i++ para ir adicionando mais números de 1 em 1 até 10. exemplo de adicionar de 2 em 2: i += 2;
            //}
            //for (i = 1; i <= 10; i++) {    //FORMA MAIS UTILIZADA COM FOR, COLOCAMOS DECLARAÇÃO DA VARIAVEL, A EXPRESSÃO QUE DIRA SE É VERDADEIRO OU FALSO E O INCREMENTO ++, --.
            //    Console.WriteLine($"O valor de i é: {i}");
            //}
            
            double somatorio = 0;
            string entrada;
            
            Console.WriteLine("Informe o tamanho da turma: "); //Quantidade determinada de repetições em cima do tamanho da turma.
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++) {
                Console.Write("Informe a nota {0}: ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual; //Atribuição aditiva, não estou substituindo e sim acrescentando todas as notas em "somatorio".
            }
            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0; //Ao final de pegar todas as médias dos alunos, fazemos esse código. "tamanhoTurma" é maior do que 0? se sim, pegamos a somatoria e dividimos pelo tamanhoTurma, caso contrário, o tamanho da turma será 0
            Console.WriteLine("Media da turma {0}", media);
            //
        }
    }
}
