using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.Fundamentos {
    class OperadoresRelacionais {
        public static void Executar() 
        {
            //double nota = 6.0;
            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota); 
            double notaDeCorte = 7.0;

            Console.WriteLine("Nota inválida? {0}", nota > 10.0); // Maior que
            Console.WriteLine("Nota inválida? {0}", nota < 0.0); // Menor que 
            Console.WriteLine("Perfeito? {0}", nota == 10.0); // Igualdade, comparando para ver se a nota é igual a 10 e nao a variável
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0); // Diferente. Se a nota for diferente de 10, tem como melhorar.
            Console.WriteLine("Passou por media? {0}", nota >= notaDeCorte); // Maior ou igual a nota de corte, se for menor é falso
            Console.WriteLine("Recuperação? {0}", nota < notaDeCorte); //Se a nota for menor que a notaDeCorte, o aluno será reprovado.
            Console.WriteLine("Reprovado? {0}", nota <=  3.0); // Menor ou igual, se a nota  for menor ou igual a 3, o aluno será reprovado.
        }
    }
}
