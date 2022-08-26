using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.EstruturasDeControle {
    class EstruturaIf {
        public static void Executar() {
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota); //Caso a pessoa tenha digitado de fato um número, vai converter para uma nota, se nao digitar um numero valido, o tryparse vai jogar o valor para 0.

            Console.WriteLine("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s") // Se o valor de entrada for S ou s, o valor de com comportamento será true, senão o valor será o atribuido á variável no início.
            //bomComportamento = true;

            // bomComportamento = entrada == "S" || entrada == "s"; //Se for verdadeiro, será atribuido verdadeiro e vice-versa, não precisamos da estrutura IF.
            bomComportamento = entrada.ToLower() == "s"; // ToLower = Se o valor digitado for maiúsculo, será convertido para minúsculo.

            if (nota >= 9.0 && bomComportamento) { //Se a nota for maior ou igual a 9 e bom comportamento, então o aluno irá para o quadro de honra, nesse caso colocamos em bloco entre {}
                Console.WriteLine("Quadro de Honra!"); //Um ; é  uma sentença válida no C#, portanto não podemos colocar após o IF.
            }


        }
    }
}
