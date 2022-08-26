using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProjetoCSharp.TopicosAvancados
{
    class LINQ2
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
            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            //Pegar apenas um resultado.

            Console.WriteLine($"{pedro.Nome}, {pedro.Nota}");

            var fulano = alunos.SingleOrDefault(
                aluno => aluno.Nome.Equals("Fulano"));
            if (fulano == null) {
                Console.WriteLine("Aluno não existente");
            }

            //first, primeiro que encontrar vai retornar
            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(ana.Nota);

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("Sicrano"));
            if (sicrano == null) {
                Console.WriteLine("Inexistente!");
            }


            //Retornar o último
            var outraAna = alunos.Last(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(outraAna.Nota);

            //Skip
            // Após o skip vem o número de alunos que vão ser pulados.
            var exemploSkip = alunos.Skip(2).Take(3);
            foreach (var item in exemploSkip) {
                Console.WriteLine(item.Nome);
            }
            //Pegando a maior nota dos alunos
            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            //Pegando a menor nota dos alunos
            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);

            //Somatório de todas as notas
            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatorioNotas);

            //calcular média da turma junto com a média apenas dos aprovados.
            var mediaTurma = alunos.Where(a => a.Nota >=7) 
                .Average(aluno => aluno.Nota);
            Console.WriteLine(mediaTurma);
        }
    }
}
