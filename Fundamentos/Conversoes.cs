using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.Fundamentos {
    class Conversoes 
    {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro; // Armazenar e converter um tipo int em uma variável double.
            Console.WriteLine(quebrado); //Não implicita, quando não há perigo de haver perda de informação 

            double nota = 9.7;
            int notaTruncada = (int) nota; //Explicita, quando há possibilidade de perda de informação
            Console.WriteLine("Nota truncada: {0}", notaTruncada); // Interpolação para colocar dentro da string, houve perda de informação.

            //Conversão de string para número, ter cuidado!!!
            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine(); //Armazenamos o resultado de ReadLine dentro da string "idadeString", após queremos converter o valor de string para int.
            int idadeInteira = int.Parse(idadeString); //Conversão da string idadeString para int idadeInteira.
            Console.WriteLine("Idade inserida: {0}", idadeInteira); //Interpolação para imprimir o resultado

            idadeInteira = Convert.ToInt32(idadeString); // 32 bits = 4 bytes
            Console.WriteLine("Resultado: {0}", idadeInteira); // Conseguimos converter também uma string para valor inteiro usando Convert.
           
            //

            //Forma mais segura para fazer uma conversão string para valor inteiro mesmo que eu tenha escrito um valor errado que nao seja inteiro.
            Console.WriteLine("Digite o primeiro número: ");
            string palavra = Console.ReadLine();            
            int numero1;
            int.TryParse(palavra, out numero1);//Converta a palavra e jogue dentro da variável numero que foi criada, TryParse: vai jogar o resultado para 0
            Console.WriteLine("Resultado 1: {0}", numero1);
            

            Console.WriteLine("Digite o segundo número: ");           
            int.TryParse(Console.ReadLine(), out int numero2); //Conseguimos colocar o readline diretamente ao tryparse e também declarar a variável direto.
            Console.WriteLine("Resultado 2: {1}", numero2);

            // TryParse é usado com out juntamente com a variável que será convertida e tenta fazer o Parse que caso nao consiga, joga para o valor padrão que é 0


            float teste = 25.8f;
            int valor = 25;

            teste = valor;
            Console.WriteLine(teste);
        }
    }
}
