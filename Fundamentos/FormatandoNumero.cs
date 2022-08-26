using System;
using System.Globalization;

namespace ProjetoCSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;     //Converter double para int.
            Console.WriteLine(valor.ToString("F1")); //Apenas uma casa decimal.
            Console.WriteLine(valor.ToString("C")); // Para valores monetários(moedas), no caso o valor 15.175 para moeda (local)
            Console.WriteLine(valor.ToString("P")); // Percentual % e também multiplica o valor por 100
            Console.WriteLine(valor.ToString("#.##")); // Caso eu queira um número com duas casas decimais, ou posso colocar F2.

            CultureInfo cultura = new CultureInfo("en-US"); //Criando uma nova informação de cultura, símbolos, etc.
            Console.WriteLine(valor.ToString("C0", cultura)); //Converter para valor em dinheiro sem nenhuma casa decimal e o segundo parâmetro cultura.

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // Caso eu completar com zeros a esquerda, o D10 vai completar até o número ficar com 10 posições


        }
    }
}
