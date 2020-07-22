using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.Entities; //importando
using Projeto.BLL; //importando
using Projeto.Presentation.Models; //importando
using AutoMapper;

namespace Projeto.Presentation.Controllers
{
    public class FuncionarioController : Controller
    {
        //atributo
        private FuncionarioBusiness business;

        //construtor -> ctor + 2x[tab]
        public FuncionarioController()
        {
            business = new FuncionarioBusiness();
        }

        // GET: Funcionario/Cadastro
        public ActionResult Cadastro()
        {
            return View(new FuncionarioCadastroViewModel());
        }

        // POST: Funcionario/Cadastro
        [HttpPost] //método recebe SUBMIT do formulário
        public ActionResult Cadastro(FuncionarioCadastroViewModel model)
        {
            //verificar se os campos da model passaram nas validações
            if (ModelState.IsValid)
            {
                try
                {
                    var funcionario = Mapper.Map<Funcionario>(model);
                    business.CadastrarFuncionario(funcionario);

                    TempData["Mensagem"] = $"Funcionário { funcionario.Nome}, cadastrado com sucesso";
                    ModelState.Clear();
                }
                catch (Exception e)
                {
                    TempData["Mensagem"] = e.Message;
                }
            }

            return View(new FuncionarioCadastroViewModel());
        }

        // GET: Funcionario/Consulta
        public ActionResult Consulta()
        {

            List<FuncionarioConsultaViewModel> lista
                = new List<FuncionarioConsultaViewModel>();

            try
            {
                lista = Mapper.Map<List<FuncionarioConsultaViewModel>>
                        (business.ConsultarFuncionarios());
            }
            catch (Exception e)
            {
                TempData["Mensagem"] = e.Message;
            }

            //enviando a lista para a view
            return View(lista);
        }

        // POST: Funcionario/Consulta
        [HttpPost] //recebe requisições do tipo POST
        public ActionResult Consulta(string nome)
        {
            List<FuncionarioConsultaViewModel> lista
            = new List<FuncionarioConsultaViewModel>();

            try
            {
                lista = Mapper.Map<List<FuncionarioConsultaViewModel>>
                        (business.ConsultarFuncionariosPorNome(nome));
            }
            catch (Exception e)
            {
                TempData["Mensagem"] = e.Message;
            }

            //enviando a lista para a view
            return View(lista);
        }


        public ActionResult Exclusao(int id)
        {
            try
            {
                business.ExcluirFuncionario(id);
                TempData["Mensagem"] = "Funcionário excluído com sucesso.";
            }
            catch (Exception e)
            {
                TempData["Mensagem"] = e.Message;
            }

            //redirecionamento..
            return RedirectToAction("Consulta");
        }

        public ActionResult Edicao(int id)
        {
            //criando um objeto viewmodel
            FuncionarioEdicaoViewModel model = new FuncionarioEdicaoViewModel();


            try
            {
                model = Mapper.Map<FuncionarioEdicaoViewModel>
                        (business.ConsultarFuncionarioPorId(id));
            }
            catch (Exception e)
            {
                TempData["Mensagem"] = e.Message;
            }

            return View(model);
        }

        [HttpPost] //método recebe SUBMIT do formulário
        public ActionResult Edicao(FuncionarioEdicaoViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var funcionario = Mapper.Map<Funcionario>(model);
                    business.AtualizarFuncionario(funcionario);

                    TempData["Mensagem"] = $"Funcionário { funcionario.Nome} atualizado com sucesso";
                    return RedirectToAction("Consulta"); //redirecionamento
                }
                catch (Exception e)
                {
                    TempData["Mensagem"] = e.Message;
                }
            }

            return View(new FuncionarioEdicaoViewModel());
        }
    }
}
