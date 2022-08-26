using System;
using System.Collections;
using System.Text;

namespace ProjetoCSharp.Colecoes
{
    class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack();
            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach(var pilhas in pilha)
            {
                Console.Write($"{pilhas} ");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}"); //Tirar o primeiro elemento da pilha
                                                        //e retornar o objeto que foi removido da lista.
            foreach (var pilhas in pilha)
            {                                //Vai mostrar que o último item adicionado, foi removido.
                Console.Write($"{pilhas} ");
            }
            Console.WriteLine($"\nPeek: {pilha.Peek()}"); //Pegar o próximo valor que está no topo pilha mas não vai remover.
            Console.WriteLine(pilha.Count);
        }
    }
}
