using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.DAL; //importando
using Projeto.Entities; //importando
namespace Projeto.BLL
{
    public class ProdutoBusiness
    {
        public void CadastrarProduto(Produto produto)
        {
            ProdutoRepository repository = new ProdutoRepository();
            repository.Insert(produto);
        }
        public void AtualizarProduto(Produto produto)
        {
            ProdutoRepository repository = new ProdutoRepository();
            repository.Update(produto);
        }
        public void ExcluirProduto(int idProduto)
        {
            ProdutoRepository repository = new ProdutoRepository();
            repository.Delete(idProduto);
        }
        public List<Produto> ConsultarTodos()
        {
            ProdutoRepository repository = new ProdutoRepository();
            return repository.FindAll();
        }
        public Produto ConsultarPorId(int idProduto)
        {
            ProdutoRepository repository = new ProdutoRepository();
            return repository.FindById(idProduto);
        }
        public List<Produto> ConsultarPorNome(string nome)
        {
            ProdutoRepository repository = new ProdutoRepository();
            return repository.FindByNome(nome);
        }
    }
}