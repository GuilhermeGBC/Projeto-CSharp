using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.Excecoes
{
    public class Conta
    {
        private double Saldo;

        public Conta(double saldo) {
            Saldo = saldo;
        } 
        public void Sacar(double valor) {
            if(valor > Saldo) { //Throw para lançar uma exceção que vai parar de forma bruta a execução desse método e volta para a função que chamou.  
                throw new ArgumentException("Saldo insuficiente."); //Causa do erro
            }
            Saldo -= valor; //Caso não entre no teste acima, ele vai subtrair o valor de saldo solicitado
        }
    }
    
    class PrimeiraExcecao
    {
        public static void Executar() {
            var conta = new Conta(1_223.45);

            try { //Pode causar um erro.
                conta.Sacar(1600);
                Console.WriteLine("Retirada com sucesso!");
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally { //Executado em qualquer situação.
                Console.WriteLine("Obrigado!");
            }
            


        }
    }
}
