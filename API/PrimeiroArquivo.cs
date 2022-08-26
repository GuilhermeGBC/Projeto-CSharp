using System;
using System.IO;

namespace ProjetoCSharp.API
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path) { //Para substituir o ~ pela pasta HOME.
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
                 return path.Replace("~", home);
        }
    }

    class PrimeiroArquivo
    {
        public static void Executar() {
                                                 //PARSEHOME PARA SUBSTITUIR O ~ PELA PASTA HOME.
            var path = @"~/primeiro_arquivo.txt".ParseHome(); //Lembrar: @ para eliminar "caracteres especiais" na execução do código, por exemplo: irá ignorar \n para quebrar a linha.

            if(!File.Exists(path)) {
                using(StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                }
            }
            using (StreamWriter sw = File.AppendText(path)) {
                sw.WriteLine("");
                sw.WriteLine("É possível"); //Editando texto no arquivo existente.
                sw.WriteLine("adicionar");
                sw.WriteLine("mais texto!");
            }
        }
    }
}
