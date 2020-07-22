using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//namespace -> define o local da classe
//dentro do projeto (caminho virtual)
namespace Projeto01.Entidades
{
    //definição da classe
    //public -> acesso total
    public class Cliente
    {
        //atributos (dados)
        private int idCliente;
        private string nome;
        private string email;
        //métodos set/get
        public int IdCliente //propriedade (método set/get)
        {
            set { idCliente = value; } //entrada
            get { return idCliente; } //saída
        }
        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }
        public string Email
        {
            set { email = value; }
            get { return email; }
        }
    }
}