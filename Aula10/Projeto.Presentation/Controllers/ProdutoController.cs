using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.Presentation.Models;
using Projeto.BLL;
using Projeto.Entities;
//PARA OS RELATÓRIOS iTextSharp
using System.Diagnostics;
using System.Text;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;


namespace Projeto.Presentation.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto/Cadastro
        public ActionResult Cadastro()
        {
            return View();
        }

        // GET: Produto/Consulta
        public ActionResult Consulta()
        {
            return View();
        }

        //método que será executado pela chamada AJAX feita na página
        public JsonResult CadastrarProduto(ProdutoCadastroViewModel model)
        {
            //verificar se os dados da model passaram nas regras de validação
            if (ModelState.IsValid)
            {
                try
                {
                    Produto produto = new Produto();
                    produto.Nome = model.Nome;
                    produto.Preco = model.Preco;
                    produto.Quantidade = model.Quantidade;

                    ProdutoBusiness business = new ProdutoBusiness();
                    business.CadastrarProduto(produto);

                    return Json($"Produto {produto.Nome},cadastrado com sucesso.");
                }
                catch (Exception e)
                {
                    Response.StatusCode = 500; //INTERNAL SERVER ERROR
                    return Json(e.Message);
                }
            }
            else
            {
                //forçar o JsonResult a retornar um status de erro
                //para a função JQUERY...
                Response.StatusCode = 400; //BAD REQUEST
                //retornar as mensagens de erro de validação
                List<string> erros = new List<string>();
                foreach (var state in ModelState)
                {
                    if (state.Value.Errors.Count > 0)
                    {
                        erros.Add(state.Value.Errors
                                    .Select(e => e.ErrorMessage)
                                    .FirstOrDefault());
                    }
                }

                return Json(erros);
            }
        }

        //método para retornar a consulta de produtos para o jquery
        public JsonResult ConsultarProdutos()
        {
            try
            {
                List<ProdutoConsultaViewModel> lista
                = new List<ProdutoConsultaViewModel>();

                //executar a consulta de produtos na camada de regras de negócio
                ProdutoBusiness business = new ProdutoBusiness();
                foreach (Produto produto in business.ConsultarTodos())
                {
                    ProdutoConsultaViewModel model
                = new ProdutoConsultaViewModel();
                    model.IdProduto = produto.IdProduto;
                    model.Nome = produto.Nome;
                    model.Preco = produto.Preco;
                    model.Quantidade = produto.Quantidade;
                    model.Total = produto.Preco * produto.Quantidade;

                    lista.Add(model); //adicionar na lista
                }

                return Json(lista); //retornando a lista
            }
            catch (Exception e)
            {
                Response.StatusCode = 500; //INTERNAL SERVER ERROR

                //retornando mensagem de erro..
                return Json(e.Message);
            }
        }

        //método pra consultar 1 produto pelo id
        public JsonResult ConsultarProdutoPorId(int id)
        {
            try
            {
                ProdutoConsultaViewModel model = new ProdutoConsultaViewModel();

                //buscar o produto pelo id
                ProdutoBusiness business = new ProdutoBusiness();
                Produto produto = business.ConsultarPorId(id);


                model.IdProduto = produto.IdProduto;
                model.Nome = produto.Nome;
                model.Preco = produto.Preco;
                model.Quantidade = produto.Quantidade;
                model.Total = produto.Preco * produto.Quantidade;

                return Json(model); //retornando o objeto model..
            }
            catch (Exception e)
            {
                Response.StatusCode = 500; //INTERNAL SERVER ERROR
                return Json(e.Message); //mensagem de erro
            }
        }

        //método para excluir um produto
        public JsonResult ExcluirProduto(int id)
        {
            try
            {
                ProdutoBusiness business = new ProdutoBusiness();
                business.ExcluirProduto(id);

                return Json("Produto excluído com sucesso.");
            }
            catch (Exception e)
            {
                Response.StatusCode = 500; //INTERNAL SERVER ERROR
                return Json(e.Message); //mensagem de erro                
            }
        }


        //método que será executado pela chamada AJAX feita na página
        public JsonResult AtualizarProduto(ProdutoEdicaoViewModel model)
        {
            //verificar se os dados da model passaram nas regras de validação
            if (ModelState.IsValid)
            {
                try
                {
                    Produto produto = new Produto();
                    produto.IdProduto = model.IdProduto;
                    produto.Nome = model.Nome;
                    produto.Preco = model.Preco;
                    produto.Quantidade = model.Quantidade;

                    ProdutoBusiness business = new ProdutoBusiness();
                    business.AtualizarProduto(produto);

                    return Json($"Produto {produto.Nome},atualizado com sucesso.");
                }
                catch (Exception e)
                {
                    Response.StatusCode = 500; //INTERNAL SERVER ERROR
                    return Json(e.Message);
                }
            }
            else
            {
                //forçar o JsonResult a retornar um status de erro
                //para a função JQUERY...
                Response.StatusCode = 400; //BAD REQUEST
                //retornar as mensagens de erro de validação
                List<string> erros = new List<string>();
                foreach (var state in ModelState)
                {
                    if (state.Value.Errors.Count > 0)
                    {
                        erros.Add(state.Value.Errors
                                    .Select(e => e.ErrorMessage)
                                    .FirstOrDefault());
                    }
                }

                return Json(erros);
            }
        }
        //método para realizar o download do relatório em PDF..
        //URL: Produto/Relatorio
        public void Relatorio()
        {
            try
            {
                //PASSO 1) Escrever o conteúdo do relatório em formato HTML
                StringBuilder conteudo = new StringBuilder();

                conteudo.Append("<h2>Relatório de Produtos</h2>");
                conteudo.Append($"Relatório gerado em: {DateTime.Now}");
                conteudo.Append("<br/><br/>");

                conteudo.Append("<table border='1' style='width: 100%'>");

                conteudo.Append("<tr>");
                conteudo.Append("<th>Código</th>");
                conteudo.Append("<th>Nome do Produto</th>");
                conteudo.Append("<th>Preço</th>");
                conteudo.Append("<th>Quantidade</th>");
                conteudo.Append("</tr>");

                //buscar os produtos na base de dados
                ProdutoBusiness business = new ProdutoBusiness();
                List<Produto> lista = business.ConsultarTodos();

                //percorrer a lista..
                foreach (Produto produto in lista)
                {
                    conteudo.Append("<tr>");
                    conteudo.Append($"<td>{produto.IdProduto}</td>");
                    conteudo.Append($"<td>{produto.Nome}</td>");
                    conteudo.Append($"<td>{produto.Preco}</td>");
                    conteudo.Append($"<td>{produto.Quantidade}</td>");
                    conteudo.Append("</tr>");
                }

                conteudo.Append("</table>");
                conteudo.Append("<br/>");
                conteudo.Append($"Quantidade de registros: {lista.Count}");

                //PASSO 2) Utilizando o iTextSharp para transformar 
                //o conteudo HTML do passo 1 em um arquivo PDF

                byte[] pdf = null;

                MemoryStream ms = new MemoryStream();
                TextReader reader = new StringReader(conteudo.ToString());

                Document doc = new Document(PageSize.A4, 50, 50, 50, 50);
                PdfWriter writer = PdfWriter.GetInstance(doc, ms);
                HTMLWorker html = new HTMLWorker(doc);

                doc.Open();
                html.StartDocument();
                html.Parse(reader);
                html.EndDocument();
                html.Close();
                doc.Close();

                pdf = ms.ToArray();

                //PASSO 3) Utilizar o MVC para fazer o download do PDF
                Response.Clear();
                Response.ContentType = "application/pdf";
                Response.AddHeader("content-disposition",
                    "attachment; filename=relatorio.pdf");
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.BinaryWrite(pdf);
                Response.End();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

    }
}
