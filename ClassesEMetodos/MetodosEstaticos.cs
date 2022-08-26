using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.ClassesEMetodos {

    public class CalculadoraEstatica {
        
        public static int Multiplicar(int a, int b) {
            return a * b;
        }
        public int Somar(int a, int b) { // Public = Visível para qualquer outro código acessar, static foco da aula, tipo de retorno, nome do método e parâmetros de entrada, depois o retorno.
            return a + b;                         
        }
    }

    class MetodosEstaticos 
    {
        public static void Executar() {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);  //Método para usar static, que não pertence mais ao objeto e sim a classe.  ACESSÍVEL A PARTIR DA CLASSE.        
            Console.WriteLine($"Resultado: {resultado}");
            

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2,2)); //Método para caso não utilizar static, devemos criar uma instância desse tipo. SÓ É ACESSÍVEL ATRAVÉS DE INSTÂNCIA.
        }
    }
}
