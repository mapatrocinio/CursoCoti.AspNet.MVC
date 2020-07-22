using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; //validações
using System.Web.Mvc;
using Projeto.Entities;
using Projeto.BLL;

namespace Projeto.Presentation.Models
{
    public class FuncionarioCadastroViewModel
    {

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public decimal Salario { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime DataAdmissao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int IdSetor { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int IdFuncao { get; set; }

        //propriedade para popular o campo
        //DropDownList referente a Setor
        public List<SelectListItem> Setores
        {
            get
            {
                List<SelectListItem> lista = new List<SelectListItem>();

                SetorBusiness business = new SetorBusiness();
                foreach (Setor setor in business.ConsultarSetores())
                {
                    SelectListItem item = new SelectListItem();
                    item.Value = setor.IdSetor.ToString();
                    item.Text = setor.Nome;

                    lista.Add(item);
                }

                return lista;
            }
        }

        //propriedade para popular o campo
        //DropDownList referente a Função
        public List<SelectListItem> Funcoes
        {
            get
            {
                List<SelectListItem> lista = new List<SelectListItem>();

                FuncaoBusiness business = new FuncaoBusiness();
                foreach (Funcao funcao in business.ConsultarFuncoes())
                {
                    SelectListItem item = new SelectListItem();
                    item.Value = funcao.IdFuncao.ToString();
                    item.Text = funcao.Nome;

                    lista.Add(item);
                }

                return lista;
            }
        }
    }
}
