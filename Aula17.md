Srviços

1.2 - Serviços
Projeto Asp.Net .NET Framework (WebApi)

Instalando o AutoMapper: (8.1.0)
Gerenciador de pacotes do NuGet

Criando controller do projeto WebApi
Classe utilizada para disponibilizar os serviços de Cliente no projeto API
(Adicionar --> Controlador - Controlador WEB API 2 (Vazio)

ClienteController

Swagger (swashbuckle 5.6.0)
Framework utilizado para gerar 
documentação em projetos do tipo API.

Setnado projeto inicial Projeto.Services

Alterando a página inicial do projeto: swagger

Projeto.Services --> Properties --> Web --> Página Específica - swagger

{
"Nome": "Miguel Angelo",
"Email": "mapatrocinio@gmail.com"
}

CONTINUA AULA 18

Criando uma regra de negócio para não permitir que 
clientes com o mesmo email sejam cadastrados na API

ENVIO DE E-MAIL
\Web.config.xml
Mapeando os parametros necessários 
para realizar o envio do email.

Voltando na camada de regras de negócio:
Adicionando referencia para System.Configuration

REST WEB API

O acrônimo API que provém do inglês Application Programming Interface (Em português, significa Interface de Programação de Aplicações), 
trata-se de um conjunto de rotinas e padrões estabelecidos e documentados por uma aplicação A, para que outras aplicações consigam utilizar 
as funcionalidades desta aplicação A, sem precisar conhecer detalhes da implementação do software. 

Desta forma, entendemos que as APIs permitem uma interoperabilidade entre aplicações. Em outras palavras, a comunicação entre aplicações e entre os usuários.

1.1 - Apresentação
Projeto Asp.Net .NetFramework vazio
Projeto de teste

Bootstrap (4.3.1)

Página inicial no projeto:
/Index.html

Definindo multiplos projetos de inicialização na solution
(Vários projetos de inicialização)

CONTINUA AULA 19

Instalando o AngularJS no projeto Presentation (1.7.8)
Gerenciador de pacotes do NuGet

Para que um projeto WebAPI aceite receber requisições de projetos externos, é necessário habilitarmos uma configuração chamada de Access-Control-Allow-Origin
Global.asax

Tarefa 1) Realizar o cadastro do cliente na camada de apresentação fazendo acesso ao serviço POST

$scope
Objeto do Angular utilizado para manipular os 
elementops HTML da página bem como seu estado.

$http
Objeto do Angular utilizado para acessar os serviços
da API (Requisições POST, PUT, DELETE e GET)

http://localhost:50053/
http://localhost:49767/swagger/ui/index










