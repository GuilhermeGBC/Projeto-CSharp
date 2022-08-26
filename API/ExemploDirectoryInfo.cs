using System;
using System.IO;

namespace ProjetoCSharp.API
{
    class ExemploDirectoryInfo
    {
        public static void Executar() {
            var dirProjeto = @"~/source/repos/ProjetoCSharp".ParseHome();

            var dirInfo = new DirectoryInfo(dirProjeto);

            if (!dirInfo.Exists) {
                dirInfo.Create();
            }
            Console.WriteLine("====== Arquivos =====");
            var arquivos = dirInfo.GetFiles();

            foreach (var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("===== Diretórios =====");
            var pastas = dirInfo.GetDirectories();
            foreach (var pasta in pastas) {
                Console.WriteLine(pasta);
            }
            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent);
        }
    }
}
