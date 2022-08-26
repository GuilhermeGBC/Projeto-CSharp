using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoCSharp.TopicosAvancados
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;
    }
    class LINQ1
    {
        public static void Executar() {
            var alunos = new List<Aluno> { //Criando a lista alunos em cima da variavel "alunos" e puxando os atributos da classe "Aluno'.
                new Aluno() {Nome = "Pedro", Idade = 24, Nota = 8.0},
                new Aluno() {Nome = "Andre", Idade = 21, Nota = 4.3},
                new Aluno() {Nome = "Ana", Idade = 25, Nota = 9.5},
                new Aluno() {Nome = "Jorge", Idade = 20, Nota = 8.5},
                new Aluno() {Nome = "Ana", Idade = 21, Nota = 7.7},
                new Aluno() {Nome = "Julia", Idade = 22, Nota = 7.5},
                new Aluno() {Nome = "Marcio", Idade = 18, Nota = 6.8}

            };
            //Filtraremos apenas os alunos aprovados usando o fator pela nota >= 7.

            Console.WriteLine("========== LISTA DE APROVADOS ==========");

            //var aprovados = alunos.Where(a => a.Idade > 24); //Passando uma função para where que retorna verdadeiro ou falso.
            var aprovados = alunos.Where(a => a.Nota >= 7).OrderBy(a => a.Nome); //Vai ordenar por ordem alfabetica, mas podemos colocar por nota também.

            foreach (var aluno in aprovados) {
                Console.WriteLine(aluno.Nome);

            }
            Console.WriteLine("=====\n == Chamada =====");

            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome); //Transformando o objeto completo apenas no a.Nome
            foreach (var aluno in chamada) {
                Console.WriteLine(aluno); //Se torna uma string e nao mais um objeto aluno.
            }
            Console.WriteLine("===== Aprovador POR IDADE =====");
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;
        }
    }
}
