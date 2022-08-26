using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.Fundamentos {
    class OperadoresUnarios {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); // Com o operador negativo na frente faz o resultado se tornar positivo e se for positivo, transforma para negativo.
            Console.WriteLine(!booleano); // Inverte o verdadeiro para falso e vice-versa.

            numero1++; //Operador pós-fixado
            Console.WriteLine(numero1);
            --numero1;// Operador pré-fixado
            Console.WriteLine(numero1);

            Console.WriteLine(numero1-- == --numero2); //O resultado será verdadeiro, pois o -- está prefixado e será executado primeiro, enquanto o ++ está pós-fixado, será executado depois.
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}
