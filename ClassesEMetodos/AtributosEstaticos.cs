using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.ClassesEMetodos {
    public class Produto {
        public string Nome;
        public double Preco;  //ATRIBUTOS DO PRODUTO/OBJETO
        public static double Desconto = 0.1; //Quando adicionamos STATIC, ele se torna um atributo de classe e não de instância. Teremos o acesso a ele da forma: Produto.Desconto = 0.5;

        public Produto(string nome, double preco, double desconto) { //CONSTRUTOR QUE RECEBE OS PARÂMETROS
            Nome = nome;
            Preco = preco;  //ATRIBUIÇÃO DOS PARÂMETROS RECEBIDOS PELO CONSTRUTOR ^
            Desconto = desconto; //COMO NENHUM DOS TRÊS É ESTÁTICO, ESSES ATRIBUTOS SÃO ESPECÍFICOS PRA CADA UM DOS OBJETOS
        }
        public Produto() {  //CONSTRUTOR PADRÃO

        }
        public double CalcularDesconto() { //CALCULAR O VALOR DO PRODUTO COM DESCONTO.
            return Preco - Preco * Desconto;
        }
    }

    class AtributosEstaticos {
        public static void Executar() {
            var produto1 = new Produto("Caneta", 3.2, 0.1);
            //CHAMANDO DIFERENTES CONSTRUTORES
            var produto2 = new Produto() {
                Nome = "Borracha",
                Preco = 5.3,
               // Desconto = 0.1 <<< Para caso o atributo DESCONTO não seja static, adicionamos valor próprio para um objeto.
            };
            Produto.Desconto = 0.5; //COM O METODO STATIC, ADICIONAMOS ESSE VALOR A TODOS OS PRODUTOS POR QUE PERTENCE A CLASSE E NÃO AS INSTÂNCIAS

            Console.WriteLine("Preço com desconto: {0}", 
                produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}", 
                produto2.CalcularDesconto());
            
            Produto.Desconto = 0.02;

            Console.WriteLine("Preço com desconto: {0}",
                produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}",
                produto2.CalcularDesconto());
        }
    }
}
