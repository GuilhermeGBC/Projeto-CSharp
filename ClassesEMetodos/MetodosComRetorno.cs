using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.ClassesEMetodos 
{
    class CalculadoraComum {
        
        public int Somar(int a, int b) { //Tipo inteiro, nome do método e 2 parâmetros de dentrada do tipo int
            return  a + b; //Como o método tem 2 parâmetros de entrada, precisamos colocar return pois é o que ele "promete" retornar.
        }          //Podemos deixar com o mesmo nome "Somar", porém devemos mudar o tipo da variável e quantas variáveis, não podemos ter 2 variáveis em cima e 2 em baixo, sempre uma a mais.
        
        /*public int Somar(int a, int b, int c)
        {
            return a + b / c;   CASO PRECISAR COLOCAR A MESMA ASSINATURA, DEVEMOS MUDAR A QUANTIDADE DE PARÂMETROS QUE HÁ EM CADA UMA, COMO AQUI POR EXEMPLO.
        }
        */

        public int Subtrair(int a, int b) { //assinatura entre parenteses
            return a - b;
        }
        
        public int Multiplicar(int a, int b) {
            return a * b;
        }
    }
    class CalculadoraCadeia {        
        int memoria; //variável não pública e sim interna

        public CalculadoraCadeia Somar(int a) { //Em vez de retornar um inteiro, vai retornar a própria calculadora cadeia. Resultado de Somar será CalculadoraCadeia
            memoria += a; //Acrescentando ao valor de memória aquilo que foi definido como parâmetro do método somar que vai retornar o método CalculadoraCadeia para que o usuário possa chamar o Somar novamente.
            return this; //retornando o próprio objeto "calculadoracadeia" 
        }
        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }
        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }
        public CalculadoraCadeia Imprimir() { //Limpar e imprimir não recebem nenhum parâmetro
            Console.WriteLine(memoria);
            return this;
        }
        public int Resultado() {
            return memoria; //Cada memória criada é uma mémória independente, podendo armazenar diferentes resultados, função return retorna o próprio objeto que estou trabalhando, fazendo com que eu possa chamar outras funções armazenando sempre na memória.
        }
    }
    

    class MetodosComRetorno {
        public static void Executar() {
            var CalculadoraComum = new CalculadoraComum(); //Construtor. Pegamos o nome da classe CalculadoraComum e criamos um new em cima dela. "Instância"
            var resultado = CalculadoraComum.Somar(5,5);
            Console.WriteLine($"O resultado do cálculo é: {resultado}");

            Console.WriteLine(CalculadoraComum.Subtrair(2,7)); //Podemos também já chamar outros parâmetros pelo construtor.
            Console.WriteLine(CalculadoraComum.Multiplicar(4,4));

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir()
                .Limpar().Imprimir(); //Chamando várias chamadas em cadeia com notação ponto, OBS: COM O SEGUNDO CONSTRUTOR DA CLASS CALCULADORACADEIA!!

            resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado(); //Última chamada é do tipo inteiro então não podemos chamar outros métodos.
            Console.WriteLine(resultado);
        }
    } 
}
