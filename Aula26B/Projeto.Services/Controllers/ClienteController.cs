using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Services.Models;

namespace Projeto.Services.Controllers
{
    [Produces("application/json")]
    [Route("api/Cliente")]
    public class ClienteController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody] ClienteCadastroViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok("Cliente cadastrado com sucesso.");
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] ClienteEdicaoViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok("Cliente atualizado com sucesso.");
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("Cliente excluído com sucesso.");
        }

        [HttpGet]
        [Produces(typeof(List<ClienteConsultaViewModel>))]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        [Produces(typeof(ClienteConsultaViewModel))]
        public IActionResult GetById(int id)
        {
            return Ok();
        }
    }
}
