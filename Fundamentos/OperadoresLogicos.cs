using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.Fundamentos {
    class OperadoresLogicos {
        public static void Executar() 
        {
            var executouTrabalho1 = true;
            //Variáveis tipo BOOL = verdadeiro ou falso
            var executouTrabalho2 = false;
            

            var comprouTv50 = executouTrabalho1 && executouTrabalho2; // && "E"
            Console.WriteLine($"Comprou a Tv 50? {comprouTv50}");

            var comprouSorvete = executouTrabalho1 || executouTrabalho2; //Operador aritmético OU
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2; // Executa um ou outro
            Console.WriteLine("Comprou Tv 32? {0}", comprouTv32);
            
            Console.WriteLine("Mais saudável? {0}", !comprouSorvete); //Se for verdadeiro passa a ser falso e vice-versa, ou seja mais saudável se não comprou o sorvete. Unário
        }
    }
}
