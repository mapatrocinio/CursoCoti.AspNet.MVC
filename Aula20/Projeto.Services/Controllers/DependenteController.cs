using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper; //importando
using Projeto.Entities; //importando
using Projeto.Services.Models; //importando
using Projeto.BLL.Contracts; //importando

namespace Projeto.Services.Controllers
{
    [RoutePrefix("api/Dependente")]
    public class DependenteController : ApiController
    {
        //atributo
        private IDependenteBusiness business;

        //construtor para inicializar o atributo
        public DependenteController(IDependenteBusiness business)
        {
            this.business = business;
        }

        [HttpPost] //requisições do tipo POST
        public HttpResponseMessage Post(DependenteCadastroViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //transferir os dados da model para entidade
                    var dependente = Mapper.Map<Dependente>(model);
                    business.Cadastrar(dependente);

                    return Request.CreateResponse(HttpStatusCode.OK,
                        $"Dependente {model.Nome}, cadastrado com sucesso.");
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

        [HttpPut] //requisições do tipo PUT
        public HttpResponseMessage Put(DependenteEdicaoViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //transferir os dados da model para entidade
                    var dependente = Mapper.Map<Dependente>(model);
                    business.Atualizar(dependente);

                    return Request.CreateResponse(HttpStatusCode.OK,
                        $"Dependente {model.Nome}, atualizado com sucesso.");
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
                var dependente = business.ConsultarPorId(id);
                business.Excluir(dependente);

                return Request.CreateResponse(HttpStatusCode.OK,
                         $"Dependente {dependente.Nome} excluído com sucesso.");
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
                var dependentes = business.ConsultarTodos();
                var model = Mapper
            .Map<List<DependenteConsultaViewModel>>(dependentes);

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
                var dependente = business.ConsultarPorId(id);
                var model = Mapper.Map<DependenteConsultaViewModel>(dependente);

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
