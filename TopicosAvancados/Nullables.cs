using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.TopicosAvancados
{
    class Nullables
    {
        public static void Executar() {
            Nullable<int> num1 = null; //< Número inteiro que recebe nulo.
            int? num2 = null; //Com ? podemos dizer que o tipo aceita nulo.
            //int num3 = null;  < Não permitido

            if (num1.HasValue) {
                Console.WriteLine("Valor de num: {0}", num1);
            }
            else {
                Console.WriteLine("A variável não possui valor.");
            }

            //setar um valor dentro de um inteiro
            int valor = num1 ?? 1000; //Se o num1 estiver nulo, vai pegar o valor padrão 1000.
            Console.WriteLine(valor);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();
            Console.WriteLine(resultado); //valor falso

            try {
                int x = num1.GetValueOrDefault();
                int y = num2.GetValueOrDefault();
                Console.WriteLine(x + y);
            }
            catch (Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
}
