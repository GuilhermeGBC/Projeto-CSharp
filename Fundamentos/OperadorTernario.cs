using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.Fundamentos {
    class OperadorTernario {
        public static void Executar() {
            var nota = 7;
            var resultado = nota >= 7.0 ? "Aprovado" : "Reprovado"; //Se a nota for maior ou igual a 7, Aprovado, senão, reprovado
            Console.WriteLine(resultado);

            //Operação com variável bool

            var nota1 = 7;
            bool bomComportamento = false;
            var resultado1 = nota1 >= 7.0 && bomComportamento
                ? "Aprovado" : "Reprovado"; //Bom comportamento true, se a nota for maior ou igual a 7 && teve um bom comportamento, aprovado, senão, reprovado.
            Console.WriteLine(resultado1);

        
        }
    }
}
