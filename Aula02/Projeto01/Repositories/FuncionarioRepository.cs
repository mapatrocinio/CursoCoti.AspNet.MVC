using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities; //importando
using System.IO; //importando

namespace Projeto01.Repositories
{
    public class FuncionarioRepository
    {
        //método para exportar os dados de um funcionário
        //para arquivo de extensão TXT
        public void ExportarParaTxt(Funcionario funcionario)
        {
            //criando uma variável para definir o nome do arquivo
            string nomeArquivo = string.Format("funcionario_{0}.txt",
                                    DateTime.Now.ToString("ddMMyyyyHHmmss"));

            //abrindo o arquivo para gravação..
            using (StreamWriter writer = new StreamWriter
                        ("C:\\_Pessoal\\CursoCoti\\tmp\\" + nomeArquivo))
            {
                writer.WriteLine("Id.........: "
                + funcionario.Id);

                writer.WriteLine("Nome.......: "
                + funcionario.Nome);

                writer.WriteLine("Salário....: "
                + funcionario.Salario.ToString("c")); //currency

                writer.WriteLine("Admissão...: "
                + funcionario.DataAdmissao.ToString("dd/MM/yyyy"));

                writer.WriteLine("Função.....: "
                + funcionario.Funcao.Descricao);

                writer.WriteLine("CodSetor...: "
                + funcionario.Setor.Codigo);

                writer.WriteLine("Setor......: "
                + funcionario.Setor.Nome);
            }
        }
    }
}
