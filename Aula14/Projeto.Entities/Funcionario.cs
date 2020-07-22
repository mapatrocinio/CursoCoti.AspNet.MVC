using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }

        public int IdSetor { get; set; } //FK no banco de dados
        public int IdFuncao { get; set; } //FK no banco de dados
        //Relacionamento com as demais classes
        public Setor Setor { get; set; } //Funcionario TEM 1 Setor
        public Funcao Funcao { get; set; } //Funcionario TEM 1 Função

        public Funcionario()
        {

        }

        public Funcionario(int idFuncionario, string nome, decimal salario,
                DateTime dataAdmissao)
        {
            IdFuncionario = idFuncionario;
            Nome = nome;
            Salario = salario;
            DataAdmissao = dataAdmissao;
        }

        public override string ToString()
        {
            return $"Id: {IdFuncionario}, Nome: {Nome}, Salário: { Salario}, Admissão: { DataAdmissao}";
        }
    }
}
