using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02Aula03.Entities; //importando
using System.Xml; //importando


namespace Projeto02Aula03.Repositorio
{
    public class GerarXml
    {
        public void ExportarParaXml(Produto produto)
        {
            //abrir um arquivo XML..
            using (XmlWriter xmlWriter = XmlWriter
                        .Create("c:\\TEMP\\produto.xml"))
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
