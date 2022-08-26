using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.ClassesEMetodos
{
    class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            numero = numero + 1000;
        }
        public static void AlterarOut(out int numero)  // TANTO REF QUANTO OUT NÃO PODEM TER VALOR PADRÃO
        {
            //int b = 1;
            numero = 0;
            numero = numero = 15;
        }
        public static void Executar()
        {
            int a = 3;         // REF temos que inicializar com valor inicial para passar o valor para outro método.
            AlterarRef(ref a); // Não vai alterar o valor //NAO ESQUECER DE COLOCAR REF NA VARIÁVEL QUE SERÁ USADA COMO REFERÊNCIA PARA QUE NÃO HAJA CONFUSÃO DO QUE ESTÁ ACONTECENDO
            Console.WriteLine($"{a}"); //Ligação de duas vias, passamos um dado que foi criado aqui no Executar,
                                       //Nesse dado é passado a referência para dentro do AlterarRef que tem a referência do número
                                       //E consegue alterar o número internamente dentro do método

            //int b = 2; //Não precisamos declarar uma variável com valor aqui, passamos direto dentro do Executar
            AlterarOut(out int b); //OUT É UNIDIRECIONAL, É COMO SE O MÉTODO TIVESSE DEVOLVENDO UM VALOR VALOR QUE FOI PASSADO 
            Console.WriteLine(b);// receber algo que não é diretamente por parâmetro
        }
    }
}
