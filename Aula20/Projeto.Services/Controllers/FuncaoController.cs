using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Projeto.Entities; //importando
using Projeto.Services.Models; //importando
using AutoMapper; //importando
using Projeto.BLL.Contracts; //importando

namespace Projeto.Services.Controllers
{
    [RoutePrefix("api/Funcao")]
    public class FuncaoController : ApiController
    {
        //atributo
        private IFuncaoBusiness business;

        //construtor para inicializar o atributo
        public FuncaoController(IFuncaoBusiness business)
        {
            this.business = business;
        }

        [HttpPost]
        public HttpResponseMessage Post(FuncaoCadastroViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //transferir os dados da model para entidade
                    var funcao = Mapper.Map<Funcao>(model);
                    business.Cadastrar(funcao);

                    return Request.CreateResponse(HttpStatusCode.OK,
                        $"Função {model.Nome}, cadastrado com sucesso.");
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
        public HttpResponseMessage Put(FuncaoEdicaoViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //transferir os dados da model para entidade
                    var funcao = Mapper.Map<Funcao>(model);
                    business.Atualizar(funcao);

                    return Request.CreateResponse(HttpStatusCode.OK,
                        $"Função {model.Nome}, atualizado com sucesso.");
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
                var funcao = business.ConsultarPorId(id);
                business.Excluir(funcao);

                return Request.CreateResponse(HttpStatusCode.OK,
                            $"Função {funcao.Nome} excluído com sucesso.");
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
                var funcoes = business.ConsultarTodos();
                var model = Mapper.Map<List<FuncaoConsultaViewModel>>(funcoes);

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
                var funcao = business.ConsultarPorId(id);
                var model = Mapper.Map<FuncaoConsultaViewModel>(funcao);

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
