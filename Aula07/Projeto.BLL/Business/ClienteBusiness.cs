using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.DAL.Entities; //importando..
using Projeto.DAL.Repositories; //importando..
namespace Projeto.BLL.Business
{
    public class ClienteBusiness
    {
        //método para realizar o cadastro de um cliente
        //enviado pelo projeto 'Presentation'
        public void CadastrarCliente(Cliente cliente)
        {
            //instanciando o repositório
            ClienteRepository repository = new ClienteRepository();
            //verificar se o email não está cadastrado
            if (!repository.HasEmail(cliente.Email))
            {
                repository.Insert(cliente); //gravando
            }
            else
            {
                throw new Exception($"O email '{cliente.Email}'já está cadastrado no sistema.");
            }
        }
        //método para atualizar os dados do cliente
        public void AtualizarCliente(Cliente cliente)
        {
            ClienteRepository repository = new ClienteRepository();
            repository.Update(cliente);
        }
        //método para excluir os dados do cliente
        public void ExcluirCliente(int idCliente)
        {
            ClienteRepository repository = new ClienteRepository();
            repository.Delete(idCliente);
        }
        //método para retornar todos os clientes
        public List<Cliente> ConsultarTodos()
        {
            ClienteRepository repository = new ClienteRepository();
            return repository.FindAll();
        }
        //método para retornar 1 cliente pelo id
        public Cliente ConsultarPorId(int idCliente)
        {
            ClienteRepository repository = new ClienteRepository();
            Cliente cliente = repository.FindById(idCliente);
            //verificar se o cliente foi encontrado
            if (cliente != null)
            {
                return cliente; //retornando o cliente
            }
            else
            {
                throw new Exception("Cliente não encontrado.");
            }
        }
    }
}