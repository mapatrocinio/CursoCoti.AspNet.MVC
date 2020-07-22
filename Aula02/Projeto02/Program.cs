using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entities; //importando..

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n - CONTROLE DE TURMAS - \n");

            try
            {
                Turma turma = new Turma();

                turma.Professor = new Professor();
                turma.Curso = new Curso();
                turma.Alunos = new List<Aluno>();

                Console.Write("Informe o Id da Turma..................: ");
                turma.IdTurma = int.Parse(Console.ReadLine());

                Console.Write("Data de início da Turma................: ");
                turma.DataInicio = DateTime.Parse(Console.ReadLine());

                Console.Write("Nome do Professor......................: ");
                turma.Professor.Nome = Console.ReadLine();

                Console.Write("Cpf do Professor.......................: ");
                turma.Professor.Cpf = Console.ReadLine();

                Console.Write("Nome do Curso..........................: ");
                turma.Curso.Nome = Console.ReadLine();

                Console.Write("Carga horária do Curso.................: ");
                turma.Curso.CargaHoraria = int.Parse(Console.ReadLine());

                Console.Write("Informe (1)Manha, (2)Tarde ou (3)Noite.: ");
                turma.Turno = (Turno)int.Parse(Console.ReadLine());

                Console.Write("Informe a quantidade de alunos.........: ");
                int qtdAlunos = int.Parse(Console.ReadLine());

                //for + 2x[tab]
                for (int i = 0; i < qtdAlunos; i++)
                {
                    Aluno aluno = new Aluno();

                    Console.WriteLine("\n\tMatricula............: ");
                    aluno.Matricula = Console.ReadLine();

                    Console.WriteLine("\tNome..............: ");
                    aluno.Nome = Console.ReadLine();

                    //adicionando o aluno na turma..
                    turma.Alunos.Add(aluno);
                }

                //imprimindo...
                Console.WriteLine("\n - DADOS DA TURMA - \n");
                Console.WriteLine("Id da Turma........: "
                        + turma.IdTurma);
                Console.WriteLine("Data de Início.....: "
                        + turma.DataInicio);
                Console.WriteLine("Professor..........: "
                        + turma.Professor.Nome);
                Console.WriteLine("CPF................: "
                        + turma.Professor.Cpf);
                Console.WriteLine("Curso..............: "
                        + turma.Curso.Nome);
                Console.WriteLine("Carga Horária......: "
                        + turma.Curso.CargaHoraria);
                Console.WriteLine("Turno..............: "
                        + turma.Turno.ToString());
                Console.WriteLine("Qtd de Alunos......: "
                        + turma.Alunos.Count);

                //ler cada Aluno contido na lista
                foreach (Aluno aluno in turma.Alunos)
                {
                    Console.WriteLine("\n\tNome do Aluno..: " + aluno.Nome);
                    Console.WriteLine("\tMatricula......: " + aluno.Matricula);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
            }

            Console.ReadKey();
        }
    }
}
