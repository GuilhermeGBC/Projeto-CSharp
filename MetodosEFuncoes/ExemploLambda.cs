using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            Action algoNoConsole = () =>
            { //Função está após o =>
                Console.WriteLine("Lambda com C#!");
            };

            algoNoConsole();

            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7); // 7 não entra. 
            };
            Console.WriteLine(jogarDado());


            //numero é o parâmetro da função >> INT, método para quando tivermos apenas uma única sentença dentro de uma função.
            //Recebe como parâmetro um inteiro e retorna uma string.
            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234)); //Converte valor decimal para hexadecimal.

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
            String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(1, 1, 2022));
        }

        //Func<int, string> conversorHexa = (numero) => {
        //    return numero.ToString("X"); //Método da função com return.
        //};
    }
}
