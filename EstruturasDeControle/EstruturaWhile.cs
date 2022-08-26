using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.EstruturasDeControle {
    class EstruturaWhile {
        public static void Executar() {
            int palpite = 0; //Criado um palpite para o usuário
            Random random = new Random(); //Criado para um número aleatório

            int numeroSecreto = random.Next(1, 16); //Criado um intervalo entre 1 e 16, mas o 16 não entra.
            bool numeroEncontrado = false; //Valor inicial, caso o numero encontrado seja igual o numero secreto, o valor dessa variavel será alterado.
            int tentativasRestantes = 5;  //Tentativas do usuário, vai diminuindo caso ele vai errando.
            int tentativas = 0; //Tentativas atuais iniciais, vai se alterando conforme o código vai mudando.

            while (tentativasRestantes > 0 && !numeroEncontrado) { // Enquanto houver tentativas e o número não for encontrado, entre dentro do while e execute varias vezes até o numero ser encontrado ou o numero de tentativas se esgotar.
                Console.WriteLine("Insira seu palpite: ");
                string entrada = Console.ReadLine();  //NÃO ENCONTROU O NUMERO SECRETO, ESSA MENSAGEM FICARA REPETINDO PARA O USUARIO
                int.TryParse(entrada, out palpite);   //while será sempre verdadeiro ou falso, se for verdadeira o while ficará repetindo o bloco e se for falso, pulará para o próx bloco.

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite) { //Se o numero "aleatório" for igual ao palpite do usuário, então o número encontrado será verdadeiro.
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Numero encontrado em {0} tentativas", tentativas);
                    Console.BackgroundColor = corAnterior;  //Restauro para a cor anterior do background para default.
                } else if(palpite > numeroSecreto) {
                    Console.WriteLine("O número secreto é menor, tente novamente...");
                    Console.WriteLine("Você tem {0} tentativas restantes.", tentativasRestantes);
                } else { //Caso contrário, o palpite é menor do que o numero secreto.
                    Console.WriteLine("O número secreto é maior, tente novamente...");
                    Console.WriteLine("Você tem {0} tentativas restantes", tentativasRestantes);
                }
            }
        }
    }
}
