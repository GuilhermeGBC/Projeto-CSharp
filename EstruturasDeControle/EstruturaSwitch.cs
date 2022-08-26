using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.EstruturasDeControle {
    class EstruturaSwitch 
    {
        public static void Executar() 
        {
            Console.Write("Avalie o meu atendimento com uma nota de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota); //Não esquecer desse método de declarar a variável juntamente com a conversão de string para int/double, etc.

            switch (nota) {
                case 0:
                    Console.WriteLine("Péssimo");
                    Console.WriteLine("Por qual motivo você deu essa nota?");
                    string resposta = Console.ReadLine();
                    break;// Break entra no case 0, executa a sentença e após essa execução, ele chama o break que faz com que saia dessa estrutura switch e vá para a próxima linha, fora do bloco de código "FIM".
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;      //NÃO ESQUECER O BREAK APÓS A SENTENÇA.
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Ótimo");
                    break;
                default:   //Caso não tenha digitado nenhuma nota de 0 a 5, irá imprimir nota inválida.
                    Console.WriteLine("Nota inválida!");
                    break;

            }
            Console.WriteLine("Agradecemos pelo seu feedback! :)");
        }
    }
}
