using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper; //importando
using Projeto.Services.Models; //importando
using Projeto.Entities; //importando
using Projeto.BLL.Contracts;

namespace Projeto.Services.Controllers
{
    [RoutePrefix("api/Funcionario")]
    public class FuncionarioController : ApiController
    {
        //atributo
        private IFuncionarioBusiness business;

        public FuncionarioController(IFuncionarioBusiness business)
        {
            this.business = business;
        }

        [HttpPost]
        public HttpResponseMessage Post(FuncionarioCadastroViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //transferir os dados da model para entidade
                    var funcionario = Mapper.Map<Funcionario>(model);
                    business.Cadastrar(funcionario);

                    return Request.CreateResponse(HttpStatusCode.OK,
                        $"Funcionario {model.Nome}, cadastrado com sucesso.");
                }
                catch (Exception e)
                {
                    //erro HTTP 500 -> INTERNAL SERVER ERROR
                    return Request.CreateResponse
                (HttpStatusCode.InternalServerError,
                            "Erro interno de servidor: " + e.Message);
                }
            }
            else
            {
                //erro HTTP 400 -> BAD REQUEST
                return Request.CreateResponse(HttpStatusCode.BadRequest,
                                        "Ocorreram erros de validação.");
            }
        }

        [HttpPut]
        public HttpResponseMessage Put(FuncionarioEdicaoViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //transferir os dados da model para entidade
                    var funcionario = Mapper.Map<Funcionario>(model);
                    business.Atualizar(funcionario);

                    return Request.CreateResponse(HttpStatusCode.OK,
                        $"Funcionario {model.Nome}, atualizado com sucesso.");
                }
                catch (Exception e)
                {
                    //erro HTTP 500 -> INTERNAL SERVER ERROR
                    return Request.CreateResponse
                (HttpStatusCode.InternalServerError,
                            "Erro interno de servidor: " + e.Message);
                }
            }
            else
            {
                //erro HTTP 400 -> BAD REQUEST
                return Request.CreateResponse(HttpStatusCode.BadRequest,
                                        "Ocorreram erros de validação.");
            }
        }

        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var funcionario = business.ConsultarPorId(id);
                business.Excluir(funcionario);

                return Request.CreateResponse(HttpStatusCode.OK,
                        $"Funcionário {funcionario.Nome} excluído com sucesso.");
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError,
                    "Erro interno de servidor: " + e.Message);
            }
        }

        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var funcionarios = business.ConsultarTodos();
                var model = Mapper.Map<List<FuncionarioConsultaViewModel>>
                (funcionarios);

                return Request.CreateResponse(HttpStatusCode.OK, model);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError,
                    "Erro interno de servidor: " + e.Message);
            }
        }

        [HttpGet]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                var funcionario = business.ConsultarPorId(id);
                var model = Mapper.Map<FuncionarioConsultaViewModel>
                (funcionario);

                return Request.CreateResponse(HttpStatusCode.OK, model);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError,
                    "Erro interno de servidor: " + e.Message);
            }
        }
    }
}
