Arquitetura baseada em camadas
Todo sistema criado em .NET deverá ser composto
de, no mínimo, 3 camadas (partes)
Presentation Layer
Camada de Apresentação (Projeto Asp.Net).
Business Logic Layer (BLL)
Camada utilizada para implementar as regras de negócio do sistema.
Data Access Layer (DAL)
Camada utilizada para acesso a base de dados.

Asp.Net
Conjunto de tecnologias da plataforma .NET voltado para desenvolvimento
de aplicações web. O Asp.Net pode ser dividido em 3 principais tecnologias:
 Asp.Net WebForms
 Asp.Net MVC
 Asp.Net WebApi

Passo a passo para criar um CRUD cliente
1 - Criar o banco de dados;
2 - Criar A TABELA;
3 - Criar a Classe Cliente;
4 - Criando a classe para armazenar os registros de Cliente em banco de dados
	Para que possamos obter a string de conexão do arquivo Web.config.xml
	é necessário adicionar no projeto uma referência para
	System.Configuration
5 - Criar a Camada de Regras de Negócio (Projeto.BLL);

Projeto.BLL Referência para Projeto.DAL;
Projeto.Presentation Referência para Projeto.DAL e BLL;
 
MasterPage
Criando uma página de layout padrão. Geralmente em Asp.Net MVC
as páginas de layout mestre ficam dentro de \Views\Shared

Adicionar --> novo modo de exibição

@Razor
Recurso utilizado em Asp.Net MVC para escrever pequenos
trechos de código C# dentro de páginas HTML.

Criando a página inicial do projeto:
Em MVC, toda página web é composta de um endereço abaixo:
/Home/Index
[Controller] [View]
** Toda página (View) em MVC é criada a partir de uma classe de controle.
Para toda página que criamos em MVC precisamos de uma classe de
controle que gerencie o conteúdo desta página.

Conttrollers --> Adicionar controlador
HomeControler

Para adicionar exibição clicar com o botão direito e adicionar exibição
public ActionResult Index()
setar a páina de layout
~/Views/Shared/Layout.cshtml

Definir o projeto.presentation como projeto de inicialização
Definindo a página inicial do projeto no VisualStudio:

Os metodos do controler acionam os modos de exibição da view

CONTINUA NA AULA 8

MVC - Model, View e Controller
Padrão para desenvolvimento de aplicações web separadas por 3 papéis:
View
Representa a página HTML, composta também de código CSS (Folha
de Estilo) e também JavaScript. Em Asp.Net MVC estas páginas
possuem a extensão .cshtml pois também permitem a escrita de
código C#.
Controller
Representa a classe que gerencia uma ou mais páginas (Views) do
projeto Asp.Net MVC. Também tem a responsabilidade de receber
dados enviados por formulários contidos nas páginas.
Model
Representa a classe que irá receber ou retornar os dados dos
formulários ou consultas exibidas nas páginas. Será de
responsabilidade das Models validar também estes dados de entrada
/ saida.

Projeto.Presentation.Models
ClienteCadastroViewModel

System.ComponentModel.DataAnnotations; //validações

Bootstrap (https://getbootstrap.com/) (INSTALAR DO PRESENTATION --> NUDGET)
Conjunto de bibliotecas formadas por arquivos CSS e JavaScript
para desenvolvimento de interface web de páginas (FrontEnd)

presentation/content
Pastas adicionadas no projeto:
 Content Composta de arquivos .CSS (Folha de estilo)
 Scripts Composta de arquivos .JS (JavaScript)

CONTINUA NA AULA 9

Continua na página de consulta de cliente

QueryString
Passagem de parâmetros por URL:

TempData
É capaz de transportar um conteudo para uma página
após a execução do comando RedirectToAction


