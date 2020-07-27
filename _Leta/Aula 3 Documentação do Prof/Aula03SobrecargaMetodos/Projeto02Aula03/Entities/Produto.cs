using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02Aula03.Entities
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto()
        {
            //construtor default
        }

        //Sobrecarga de método construtor (Overloading)
        public Produto(int idProduto, string nome, decimal preco, int quantidade)
        {
            IdProduto = idProduto;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

public override string ToString()
        {
            return string.Format("IdProduto: {0} - Nome: {1} - Preco :{2} Quantidade : {3}", IdProduto, Nome, Preco, Quantidade); 
        }



    }
}
