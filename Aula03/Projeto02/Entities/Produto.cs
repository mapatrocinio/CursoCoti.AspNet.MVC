using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Entities
{
    public class Produto
    {
        //prop + 2x[tab]
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        //ctor + 2x[tab]
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

        //sobrescrita do método ToString()
        public override string ToString()
        {
            return $"Id: {IdProduto}, Nome: {Nome}, Preço: { Preco}, Qtd: { Quantidade}";
        }
    }
}
