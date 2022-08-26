using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.MetodosEFuncoes {

    delegate double Operacao(double x, double y);


    class LambdaDelegate {
        public static void Executar() {
            Operacao som = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;

            Console.WriteLine(som(10,10));
            Console.WriteLine(sub(10,5));
            Console.WriteLine(mult(5,5));
        }
    }
}
