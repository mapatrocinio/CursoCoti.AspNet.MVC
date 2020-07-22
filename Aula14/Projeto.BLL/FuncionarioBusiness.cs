using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities; //importando
using Projeto.DAL; //importando

namespace Projeto.BLL
{
    public class FuncionarioBusiness
    {
        //atributo
        private FuncionarioRepository repository;

        //construtor -> ctor + 2x[tab]
        public FuncionarioBusiness()
        {
            repository = new FuncionarioRepository();
        }

        //método para cadastrar funcionario
        public void CadastrarFuncionario(Funcionario funcionario)
        {
            repository.Insert(funcionario);
        }

        //método para atualizar funcionario
        public void AtualizarFuncionario(Funcionario funcionario)
        {
            repository.Update(funcionario);
        }

        //método para excluir funcionario
        public void ExcluirFuncionario(int id)
        {
            repository.Delete(id);
        }

        //método para listar todos os funcionarios
        public List<Funcionario> ConsultarFuncionarios()
        {
            return repository.SelectAll();
        }

        //método para listar todos os funcionarios por nome
        public List<Funcionario> ConsultarFuncionariosPorNome(string nome)
        {
            return repository.SelectAllByNome(nome);
        }

        //método para obter 1 funcionário pelo id
        public Funcionario ConsultarFuncionarioPorId(int id)
        {
            return repository.SelectById(id);
        }
    }
}
