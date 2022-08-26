using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.MetodosEFuncoes
{
    class DelegatesComParametros
    {
        public delegate int Operacao(int x, int y);

        public static int Soma(int x, int y)
        {
            return x + y;
        }
        public static int Subtracao(int x, int y)
        {
            return x - y;
        }
        public static string Calculadora(Operacao op, int x, int y)
        {
            var resultado = op(x, y);
            return "Resultado: " + resultado;
        }
        public static void Executar()
        {
            Operacao subtracao = (int x, int y) => x - y;
            Console.WriteLine(Calculadora(subtracao, 3,2));

            Operacao soma = (int x, int y) => x + y;
            Console.WriteLine(Calculadora(soma, 5,5));
        }
    }
}
