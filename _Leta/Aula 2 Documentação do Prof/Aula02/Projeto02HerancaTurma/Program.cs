using Projeto02HerancaTurma.Entitites;
using Projeto02HerancaTurma.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02HerancaTurma
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("............... Cadastro de Turmas.........:");

            try
            {
                Turma turma = new Turma();
                turma.Aluno = new List<Aluno>();
                turma.Curso = new Curso();
                turma.Professor = new Professor();
                turma.Turno = new Turno();

                Console.WriteLine("Digite Id da Turma......:");
                turma.IdTurma = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a data de Inicio da Turma.....:");
                turma.DataInicio = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Digite o Nome do Professor da Turma.....:");
                turma.Professor.Nome = Console.ReadLine();

                Console.WriteLine("Informe o CPF do Professor.....:");
                turma.Professor.Cpf = Console.ReadLine();

                Console.WriteLine("Digite o Nome do Curso......:");
                turma.Curso.Nome = Console.ReadLine();

                Console.WriteLine("Digite a carga horaria do Curso.....:");
                turma.Curso.CargaHoraria = int.Parse(Console.ReadLine());

                Console.Write("Informe (1)Manha, (2)Tarde ou (3)Noite.: ");
                turma.Turno = (Turno)int.Parse(Console.ReadLine());



                Console.WriteLine("Informe a quantidade de alunos........: ");
                int quantidadeAluno = int.Parse(Console.ReadLine());

                for (int i = 1; i < quantidadeAluno; i++)
                {

                    Aluno aluno = new Aluno();

                    Console.WriteLine("Digite a Matricula do aluno .....:", aluno.IdAluno);
                    aluno.IdAluno = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o Nome do aluno{0}......:", aluno.Nome);
                    aluno.Nome = Console.ReadLine();

                    turma.Aluno.Add(aluno);


                }

                //Imprimindo
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
                + turma.Aluno.Count);

                //Ler cada aluno contido na lista
                foreach (Aluno aluno in turma.Aluno)
                {
                    Console.WriteLine("\n\tNome do Aluno..: " + aluno.Nome);
                    Console.WriteLine("\tMatricula......: " + aluno.Matricula);
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("Erro no cadastro da turma", ex.Message);
            }

        }
    }
}
