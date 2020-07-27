using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.DAL.Entites;
using Projeto.DAL.Reposotories;

namespace Projeto.BLL.Buisiness
{
    public class ClienteBusiness
    {
        public void CadastrarCliente(Cliente cliente)
        {
            ClienteRepo repository = new ClienteRepo();



            if (!repository.HasEmail(cliente.Email))
            {
                repository.Inserir(cliente);

            }
            else
            {
                throw new Exception("O Email Já está cadastrado no sistema");
            }

        }

        public void AtualizarCliente(Cliente cliente)
        {
            ClienteRepo repository = new ClienteRepo();
            repository.Update(cliente);

        }

        public void ExcluirCliente(int idCliente)
        {
            ClienteRepo repository = new ClienteRepo();
            repository.Delete(idCliente);
        }

        public List<Cliente> ConsultarTodos()
        {
            ClienteRepo repository = new ClienteRepo();
            return repository.FindAll();
        }

        public Cliente ConsultarPorId(int idCliente)
        {
            ClienteRepo repository = new ClienteRepo();
            Cliente cliente = repository.FindByID(idCliente);

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
