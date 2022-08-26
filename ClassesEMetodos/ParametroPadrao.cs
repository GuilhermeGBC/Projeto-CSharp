using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.ClassesEMetodos
{
    class ParametroPadrao
    {
        public static int Somar(int a = 1, int b = 1) //as variáveis tem valor padrão 1 caso nao seja informado no método Executar, o resultado retorna a + , ou seja, 1+1.
        {
            return a + b;
        }

        public static void Executar()
        {
            Console.WriteLine(Somar(10,23));
            Console.WriteLine(Somar(50)); //Como foi passado apenas um dos valores, será somado NumeroPassado + 1; Se não é passado por parâmetro, será entendido que foi aplicado para a primeira variável
            Console.WriteLine(Somar()); //Como não colocamos nenhum valor, será retornado o valor padrão 1, que foi definido na variável.
            Console.WriteLine(Somar(b: 7)); //Podemos também passar por parâmetro nomeado.
            Console.WriteLine(Somar(a: 10)); //Caso não estejamos trabalhando nem com REF e nem com OUT, podemos sim passar valor padrão.

           
        }
    }
}
