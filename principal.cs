using System;

namespace Console2
{
    internal class Program
    {
        protected static void Main(string[] args)
        {
            Console.Title = "Media geral dos alunos";
            Console.Write("Quantos alunos?");
            int nualunos = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Aluno[] alunos = new Aluno[nualunos];
            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Clear();
                Console.Write("Aluno " + (i+1) + "Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Aluno " + (i + 1) + "Provas: ");
                int provas = int.Parse(Console.ReadLine());
                alunos[i] = new Aluno(nome, provas);
                Console.WriteLine("Insira as notas do alunos: " + nome);
                alunos[i].InserirNotas();
            }
            Console.Clear();
            double mediaGeral = 0;
            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine("Aluno: " + aluno.Nome);
                Console.WriteLine("Media :" + aluno.Media);
                mediaGeral += aluno.Media;
            }
            double resultadoFinal = mediaGeral / alunos.Length;
            Console.WriteLine("media geral dos alunos: " + resultadoFinal);
            Console.ReadKey();
        }
    }
}

