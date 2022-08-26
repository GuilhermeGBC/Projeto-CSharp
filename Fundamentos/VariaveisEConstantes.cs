using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.Fundamentos {
    class VariaveisEConstantes 
    {
        public static void Executar() 
        {
            // área de circunferência, variável e pi
            // a variável raio armazenou o númro 4.5 mas pode ser alterada
            // já a const double não pode ser alterada, devera usar o valor de 3,14.
            
            double raio = 4.5; //Casa decimal, ou seja DOUBLE
            const double PI = 3.14;

            raio = 5.5;
            //Declaro a variavel que vai armazenar o resultado do calculo, no caso será "area"
            double area = PI * raio * raio;
            Console.WriteLine(area); //Variavel que armazenou o calculo
            Console.WriteLine("Area é:" + area); // Coloca uma introdução a resposta + nome da variável que armazenou os dados.
                                                 // Se chama concatenação quando se juntam palavras e soma quando são números.

            // Tipos Internos bool = true or false

            bool estaChovendo = true;  // bool = true or false
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 18; // números de 0 a 256
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue; // -128 a +127
            Console.WriteLine("Saldo de Gols é de "  + saldoDeGols);

            short salario = short.MaxValue; // -32768 a 32767
            Console.WriteLine("Salário "+ salario);

            int menorValorInt = int.MaxValue;// Mais usado dos inteiros
            Console.WriteLine("O menor valor inteiro é " + menorValorInt);

            uint populacao = 200_000_000; // Colocar os valores "soltos" com _
            Console.WriteLine("A população brasileira é de "+ populacao + " pessoas");

            long MaiorValorLong = long.MaxValue; // long.MaxValue e long.MinValue
            Console.WriteLine("Maior Long "+ MaiorValorLong);

            ulong populacaoMundial = 2_700_000_000_00; // Números grandes ex: 100_000_000_00
            Console.WriteLine("A população mundial é de "+ populacaoMundial + " pessoas");


            //VALORES REAIS(Flutuantes)

            float precoComputador = 5000.00f; //Caso eu queira que o valor seja do tipo float, tenho que colocar um F para atribuir dentro do float.
            Console.WriteLine("O preço do computador é "+ precoComputador + " reais");

            double valorDeMercadoMicrosoft = 1000000000.00; // mais usado dos reais
            Console.WriteLine("Valor de mercado da Microsoft é: "+ valorDeMercadoMicrosoft + " reais");

            decimal DistanciaEntreEstrelas = decimal.MaxValue; // Para valores astronômicos
            Console.WriteLine("A distância entre as estrelas é "+ DistanciaEntreEstrelas);


            char PrimeiraLetraAlfabeto = 'a'; // Pode ser delimitada por aspas simples ''. não posso colocar duas letras ou mais dentro de aspas simples, teria que colocar uma string
            Console.WriteLine("A primeira letra do alfabeto é "+ PrimeiraLetraAlfabeto);

            string texto = "Seja bem-vindo ao curso de C#"; //Cadeia de caracteres
            Console.WriteLine(texto); //Escrevo o nome da variável para reproduzir
            






        }
    }
}
