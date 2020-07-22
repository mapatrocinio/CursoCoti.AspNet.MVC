using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.DAL.Entities; //importando..
using Projeto.BLL.Business; //importando..
using Projeto.Presentation.Models; //importando..
namespace Projeto.Presentation.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente/Cadastro
        public ActionResult Cadastro()
        {
            return View();
        }
        // POST: Cliente/Cadastro
        [HttpPost] //requisições de formulário
        public ActionResult Cadastro(ClienteCadastroViewModel model)
        {
            //verificar se os campos da model passaram
            //nas regras de validação
            if (ModelState.IsValid)
            {
                try
                {
                    Cliente cliente = new Cliente();
                    cliente.Nome = model.Nome;
                    cliente.Email = model.Email;
                    cliente.DataCadastro = DateTime.Now;
                    ClienteBusiness business = new ClienteBusiness();
                    business.CadastrarCliente(cliente);
                    ViewData["Mensagem"] = "Cliente cadastrado com sucesso.";
                    ModelState.Clear(); //limpar os campos do formulário
                }
                catch (Exception e)
                {
                    ViewData["Mensagem"] = e.Message;
                }
            }
            return View();
        }
        // GET: Cliente/Consulta
        public ActionResult Consulta()
        {
            //declarar uma lista da classe ViewModel..
            List<ClienteConsultaViewModel> lista
            = new List<ClienteConsultaViewModel>();
            try
            {
                //executando a consulta de clientes..
                ClienteBusiness business = new ClienteBusiness();
                List<Cliente> consulta = business.ConsultarTodos();
                //varrer a consulta de clientes obtido..
                foreach (Cliente cliente in consulta)
                {
                    ClienteConsultaViewModel model
                    = new ClienteConsultaViewModel();
                    model.IdCliente = cliente.IdCliente;
                    model.Nome = cliente.Nome;
                    model.Email = cliente.Email;
                    model.DataCadastro = cliente.DataCadastro;
                    lista.Add(model);
                }
            }
            catch (Exception e)
            {
                //exibir mensagem de erro..
                ViewData["Mensagem"] = e.Message;
            }
            //abre a página
            return View(lista);
        }
        // GET: Cliente/Edicao/id
        public ActionResult Edicao(int id)
        {
            ClienteEdicaoViewModel model = new ClienteEdicaoViewModel();
            try
            {
                //buscando o cliente pelo id..
                ClienteBusiness business = new ClienteBusiness();
                Cliente cliente = business.ConsultarPorId(id);
                model.IdCliente = cliente.IdCliente;
                model.Nome = cliente.Nome;
                model.Email = cliente.Email;
                model.DataCadastro = cliente.DataCadastro;
            }
            catch (Exception e)
            {
                ViewData["Mensagem"] = e.Message;
            }
            return View(model);
        }
        [HttpPost] //recebe o SUBMIT do formulário
        public ActionResult Edicao(ClienteEdicaoViewModel model)
        {
            //verificar se os dados da model passaram
            //nas regras de validação..
            if (ModelState.IsValid)
            {
                try
                {
                    Cliente cliente = new Cliente();
                    cliente.IdCliente = model.IdCliente;
                    cliente.Nome = model.Nome;
                    cliente.Email = model.Email;
                    ClienteBusiness business = new ClienteBusiness();
                    business.AtualizarCliente(cliente);
                    ViewData["Mensagem"] = "Cliente atualizado com sucesso.";
                }
                catch (Exception e)
                {
                    ViewData["Mensagem"] = e.Message;
                }
            }
            return View();
        }
        public ActionResult Exclusao(int id)
        {
            try
            {
                ClienteBusiness business = new ClienteBusiness();
                business.ExcluirCliente(id);
                TempData["Mensagem"] = "Cliente excluído com sucesso.";
            }
            catch (Exception e)
            {
                TempData["Mensagem"] = e.Message;
            }
            //redirecionar para a página da consulta..
            return RedirectToAction("Consulta");
        }
    }
}