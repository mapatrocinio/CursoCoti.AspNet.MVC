using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entities; //importando
using System.Xml; //importando

namespace Projeto02.Repositories
{
    public class ProdutoRepository
    {
        public void ExportarParaXml(Produto produto)
        {
            //abrir um arquivo XML..
            using (XmlWriter xmlWriter = XmlWriter
                        .Create("C:\\_Pessoal\\CursoCoti\\tmp\\produto.xml"))
            {
                //abrir o documento xml..
                xmlWriter.WriteStartDocument();

                xmlWriter.WriteStartElement("PRODUTO"); //abrindo a TAG principal
                xmlWriter.WriteElementString("IDPRODUTO",
            produto.IdProduto.ToString());
                xmlWriter.WriteElementString("NOME",
            produto.Nome);
                xmlWriter.WriteElementString("PRECO",
            produto.Preco.ToString());
                xmlWriter.WriteElementString("QUANTIDADE",
            produto.Quantidade.ToString());
                xmlWriter.WriteEndElement(); //fechando a TAG principal
            }
        }
    }
}
