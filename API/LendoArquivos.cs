using System;
using System.IO;


namespace ProjetoCSharp.API
{
    public class LendoArquivos
    {
        public static void Executar() {
            var path = @"~/lendo_arquivos.txt".ParseHome();

            if(!File.Exists(path)) { //Se o arquivo não existir, ele vai entrar no bloco IF e criá-lo

                using(StreamWriter sw = File.AppendText(path)) {
                    sw.WriteLine("Produto;Preco;Qtd");
                    sw.WriteLine("Caneta Bic Preta;3.59;89");
                    sw.WriteLine("Borracha branca;2.89;27");
                }
            }
            try {
                using(StreamReader sr = new StreamReader(path + ".txt")) {
                    var texto = sr.ReadToEnd(); //Ler o arquivo completamente
                    Console.WriteLine(texto);
                }
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
