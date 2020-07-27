using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.DAL.Entites;
using Projeto.BLL.Buisiness;
using CadastroClientes.Models;



namespace CadastroClientes.Controllers
{
    public class ClienteController : Controller
    {
        //
        // GET: Cliente/Cadastro    
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(ClienteCadastroViewModel model) 
        
        {
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
            return View();
        }

    }
}
