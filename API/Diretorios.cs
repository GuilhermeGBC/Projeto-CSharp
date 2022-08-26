using System;
using System.IO;

namespace ProjetoCSharp.API
{
    class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDestino".ParseHome();
            var dirProjeto = @"~/source/repos/ProjetoCSharp".ParseHome();

            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true); //Acaba excluindo todos os diretórios.
            }
            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));


            Console.WriteLine("\n\n =====P4STAS=====");
            var pastas = Directory.GetDirectories(dirProjeto);
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("=====ARQUIV0S=====");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }
            Console.WriteLine("\n\n =====RAIZ=====");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            //MOVER A PASTA DO NOVODIR PARA NOVODIRDESTINO
            Directory.Move(novoDir, novoDirDestino);
        }
    }
}
