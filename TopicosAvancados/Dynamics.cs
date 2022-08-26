using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCSharp.TopicosAvancados
{
    class Dynamics
    {
        public static void Executar() {
            dynamic meuObjeto = "teste";
            meuObjeto = 0;

            meuObjeto++;
            Console.WriteLine(meuObjeto);

          

            //criando objetos dynamics
            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Guilherme";
            aluno.nota = 9.0;
            aluno.idade = 19;

            Console.WriteLine("{0}, {1}, {2}, {3}", aluno.nome, aluno.nota, aluno.idade);
        }
    }
}
