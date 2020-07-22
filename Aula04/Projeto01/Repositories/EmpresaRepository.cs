using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities; //importando
using System.IO; //importando
using Newtonsoft.Json; //importando

namespace Projeto01.Repositories
{
    public class EmpresaRepository
    {
        public void ExportarJson(Empresa empresa)
        {
            //definindo o encoding do arquivo
            Encoding encoding = Encoding.UTF8;

            //abrindo um arquivo em modo de escrita
            using (StreamWriter streamWriter
                  = new StreamWriter("C:\\_Pessoal\\CursoCoti\\tmp\\empresa.json", false, encoding))
            {
                //serializar o objeto 'empresa' para formato JSON
                string dados = JsonConvert.SerializeObject
            (empresa, Formatting.Indented);

                //escrever no arquivo..
                streamWriter.WriteLine(dados);
            }
        }

        public Empresa ImportarJson()
        {
            //abrindo um arquivo em modo de leitura
            using (StreamReader streamReader
            = new StreamReader("C:\\_Pessoal\\CursoCoti\\tmp\\empresa.json"))
            {
                //ler todo o texto contido no arquivo
                string dados = streamReader.ReadToEnd();

                //deserializar o conteudo JSON para objeto 'empresa'
                Empresa empresa = JsonConvert.DeserializeObject<Empresa>(dados);

                //retornar..
                return empresa;
            }
        }

    }

}
