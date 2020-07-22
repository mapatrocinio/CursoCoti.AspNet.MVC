using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Services.Models
{
    public class FuncaoEdicaoViewModel
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        public int IdFuncao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }
    }
}
