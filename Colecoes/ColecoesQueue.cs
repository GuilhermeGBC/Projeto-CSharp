using System;
using System.Collections.Generic;
using System.Collections;


namespace ProjetoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {        // USA GENERICS
            var fila = new Queue<string>(); //Definindo o valor string, não há como colocar outro tipo além desse;

            fila.Enqueue("Fulano"); //Adicionar um item na fila, enfileirar.
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek()); //Peek vai pegar o (primeiro) próximo a sair da fila mas não vai removê-lo da fila.
            Console.WriteLine(fila.Count); //O primeiro elemento ainda não foi removido da fila.

            Console.WriteLine(fila.Dequeue()); // Tira a primeira pessoa da fila. Desenfileirar.
            Console.WriteLine(fila.Count); //Vai mudar o valor da fila por conta do Dequeue. Contar quantos tem na fila.

            foreach (var pessoa in fila) //Mostrar quem sobrou na fila.
            {
                Console.WriteLine(pessoa);
            }
            //NÃO USA GENERICS, PODEMOS ARMAZENAR DADOS DE TIPOS DIFERENTES HETEROGÊNEOS, ACEITA REPETIÇÃO.
            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Count);
            Console.WriteLine(salada.Dequeue());
            Console.WriteLine(salada.Count);

            Console.WriteLine(salada.Contains("Item")); //Parecido com uma forma de consultar algo dentro da Queue.

            //foreach(var saladas in salada)
            //{
            //    Console.WriteLine(saladas);
            //}
        }
    }
}
