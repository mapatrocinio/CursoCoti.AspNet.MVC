using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Services.Models
{
    public class ClienteEdicaoViewModel
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [EmailAddress(ErrorMessage = "Email inválido")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Email { get; set; }
    }
}
