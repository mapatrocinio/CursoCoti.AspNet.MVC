		Exemplo com organização de solução
1 - Criar o projeto de entidades
2 - Criar o projeto de apresentação
	Projeto MVC
	Definir como proeto de inicialização
	2.1 - Criar banco de dados dentro de app_data;
	2.2 - Rodar Script para criar tabelas no banco;
	2.3 - Criar string de conexão \Web.config.xml
		Colocar sessão no xml e copiar string de conexão correta do banco
	2.4 Instalar o bootstrap para ler o XML;
	2.5 - MasterPage - Página de Layout padrão (Viewes/Shared) 
	2.6 - Criando a página inicial do projeto: 
		/Home/Index
		[Controller] [View]
		Adicionar controlador: HomeController
		Do HomeController - clicar com o botão direito no método e adicionar Exibição (Será criado autonaticamente na view)
		Setar a página de layout ~/Views/Shared/Layout.cshtml
	
	2.7 - Definindo a página inicial do projeto: Projeto.presentation --> Properties aba web -->
		definir pagina especifica Home/Index
3 - Criar o projeto de Acesso a dados
	3.1 - Projeto.DAL;
	3.2 - Referência para Projeto.Entities;
	3.3 - Referência para System.Configuration;
	3.4 - Adionar Pacote Dapper 1.60.6
		Dapper (https://dapper-tutorial.net/dapper) Framework para acesso a banco de dados em .NET
4 - Criar o projeto de Regras de Negócio:
	4.1 - Projeto.BLL;
	4.2 - Referência para Projeto.DAL e Projeto.Entities;
5 - Adicionando referencias no projeto Presentation
	5.1 - Projeto.BLL;
	5.2 - Projeto.DAL;
	5.3 - Projeto.Entities;

CONTINUA AULA 11

JQuery (http://jquery.com/)
Biblioteca para desenvolvimento baseado em linguagem JavaScript.
É composto de uma série de componentes que complementam e adicionam
recursos ao JavaScript convencional.

Ajax (Assyncronous Javascript and XML)
AJAX é um termo designado para definir o uso de Javascript para realizar a
comunicação entre cliente (página) e servidor de forma assíncrona.
Em uma requisição AJAX, quando o usuário realiza um evento na página,
uma função Java script é executada e esta função faz a chamada ao
servidor e aguarda a resposta. Neste caso ao invés de toda a página ser
renderizada (como em uma ação síncrona) somente uma parte da página
HTML será renderizada conforme o código Java script definir.

O termo AJAX usa o XML como formato para envio e recebimento de dados
entre o cliente e o servidor, porem, hoje a maioria das aplicações web tem
abandonado o XML para usar no lugar dele o formato JSON.
JSON (https://www.json.org/)

Utilizando o JQuery para realizar
o cadastro do produto:
Primeiro, precisamos definir um local dentro da página de Layout
para inserir conteúdo JavaScript proveniente das demais páginas:

Ná página layout.cshtml
@RenderSection("scripts", required : false)

/Views/Produto/Cadastro.cshtml

Criando uma classe de modelo para resgatar
e validar os dados enviados pelo JQuery:

CONTINUA AULA 12

CONTINUA AULA 13

Separando os arquivos JavaScript do projeto:

Framework para geração de 
relatórios PDF em aplicações .NET

Instalando o iTextSharp VS 5.5.1
Gerenciador de pacotes do NuGet


	
	
