using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Projeto.Entities
{
    public class Produto
    {
        //prop + 2x[tab]
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        //construtor default -> ctor + 2x[tab]
        public Produto()
        {
            //vazio
        }
        //sobrecarga de construtores (overloading)
        public Produto(int idProduto, string nome, decimal preco, int quantidade)
        {
            IdProduto = idProduto;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        //sobrescrita (override) do método ToString()
        public override string ToString()
        {
            return $"Id: {IdProduto}, Nome: {Nome}, Preço: { Preco}, Quantidade: { Quantidade}";
        }
    }
}