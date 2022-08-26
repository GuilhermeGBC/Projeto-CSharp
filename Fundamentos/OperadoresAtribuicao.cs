using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.Fundamentos 
{
    class OperadoresAtribuicao 
    {
      public static void Executar() {
            var num1 = 3; // Atribuição aditiva
            num1 = 7; // Substituimos o valor primário da variável para 7, sendo assim atribuindo aditivamente teremos o valor 17.
            num1 += 10; // num1 recebe o próprio valor do num1 +10, acrescentando um valor a variável e não substituindo. num1 = num1 + 10;
            
            num1 -= 3; //Atribuição Subtrativa, estou 3 do valor atual da variável. num1 = num1 - 3;

            num1 *= 5; // Atribuição multiplicativa, valor atual de num1 multiplicado por 5. num1 = num1 *5;

            num1 /= 2; //Atribução divisiva num1 = num1 / 2; 


            //outra forma de atribuição implicita

            int a = 1;
            int b = a;

            a++; //Operador únário, acrescentando uma unidade a variável a. //a = a + 1; Incrementar um valor
            b--; // Decremento. b = b - 1;

            // não se preocupar com o código

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria"; //Substitui o joão por maria por estarem no mesmo armazenamento.

            Console.WriteLine(c.nome);

        }
    }
}
