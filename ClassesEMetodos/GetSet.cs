using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.ClassesEMetodos {
    public class Moto {
        private string Marca;
        private string Modelo;
        private uint Cilindrada; //Sempre positivo.

        public Moto(string  marca, string modelo, uint cilindrada) {   //PRIMEIRO CONSTRUTOR
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        public Moto() { //SEGUNDO CONSTRUTOR (PADRÃO) DEIXAR A DISPOSIÇÃO

        }

        public string GetMarca() { //MÉTODO, GET tem a mesma variável de retorno do parâmetro de entrada no caso STRING. USAR PASCALCASE
            return Marca;  //Como não tem nenhum parâmetro de entrada nesse método e retorna o valor da marca, precisamos de um return.
        }

        public void SetMarca(string marca) { //VOID porque SET não retorna nada por padrão.
            Marca = marca;
        }

        public string GetModelo() {
            return Modelo;
        }
                                                 //MÉTODOS PARA TRANSFORMAR TODOS OS ATRIBUTOS EM PRIVADOS.
        public void SetModelo(string modelo) {
            Modelo = modelo;
        }

        public uint GetCilindrada() {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada) { //Podemos usar IF para impedir que valores negativos sejam colocados, porém ainda no primeiro método podemos colocar negativado.       
            // 1°OPÇÃO
            //if (cilindrada > 0) {                   //Temos que mudar no primeiro construtor, da forma que está la em cima ^^^^^^^^
            //    Cilindrada = cilindrada;  
            //}
            //2°OPÇÃO
            //Cilindrada = Math.Abs(cilindrada); // Math.Abs = valor absoluto, vai pegar o valor negativo e transforma em positivo e se for positivo continua positivo.

            Cilindrada = cilindrada; //USAMOS UINT como variável de cilindrada pois não tem sinal, não permitindo que tenha número negativo, será obrigado a passar um valor positivo.
        }
    }
    
    class GetSet {
        public static void Executar() {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(150);
            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo()
            + " " + moto2.GetCilindrada() + " " + "Cilindradas");
           
        }
    }
}
