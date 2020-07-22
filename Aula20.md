
Projeto WEBAPI
Implementação relacionamento TER 1 PARA MUITOS e TER MUITOS para MUITOS

Primeiro: Iremos criar as classes de 
entidade e seus relacionamentos:


Criando um novo controlador na API para Função
ENDPOINT: /api/Funcao


Projeto.Services.Controllers (onde ficam os métodos que serão disponibilizados)
RoutePrefix("api/Funcao") --> (indica o caminho a ser chamado)


N projeto DAL Criando as classes de modelo:
Projeto.Services.Models --> FuncaoCadastroViewModel

Fazer refencia ao EntityFramework
Mapeando a entidade Funcao no EntityFramework
/Mappings/FuncaoMapping.cs

ORM - Object Relational Mapping
Mapeamento Objeto / Relacional

Instalar o NTITIFRMEWORKNO PROJETO.DAL e no PROJETO.SERVICES (BASE)

Criando interfaces (Contratos) para todas as classes de repositorio que serão implementadas no projeto DAL

CONTINUA NA AULA 21

EntityFramework

Tecnologia .NET para acesso a bases de dados utilizando o padrão 
ORM (Mapeamento Objeto Relacional), ou seja, o EntityFramework é capaz de mapear as classes de entidade do projeto de forma que estas sejam interpretadas 
como tabelas do banco de dados.


CodeFirst

Técnica utilizada pelo EntityFramework para gerar e atualizar a estrutura do banco de dados (tabelas) conforme o mapeamento das classes de entidade.

Para que o EntityFramework possa conectar-se a uma base de dados é necessário criarmos uma classe que HERDE a classe DbContext

Migrations

Recurso do EntityFramework capaz de alterar a estrutura do banco de dados conforme o mapeamento das classes de entidade. Podemos por meio do Migrations criar 
as tabelas no banco de dados baseado no mapeamento e também atualizar a estrutura do banco de dados conforme o mapeamento for alterado.


Comando para habilitar o recurso de migrations

PM> enable-migrations
Enable-Migrations -ProjectName Projeto.DAL
Checking if the context targets an existing database...
Code First Migrations enabled for project Projeto.DAL.

Atualizando o conteudo do banco de dados
PM> update-database
update-database -ProjectName Projeto.DAL

Contratos
Interfaces para definir os métodos que serão 
desenvolvidos na camada de repositório de dados.


Repositório Genérico
Através do EntityFramework podemos criar uma classe de repositorio que possa inserir, atualizar, excluir, consultar todos e consultar por id qualquer tipo de entidade.
Projeto.DAL.Repositories --> BaseRepository

CONTINUA NA AULA 22

DIP - Principio de Inversão de Dependência
Principio SOLID que define a seguinte regra: Camadas de alto nivel não devem acessar classes baixo nivel mas sim suas abstrações (interfaces)

Simple Injector (https://simpleinjector.org) (SimpleInjector.Integration.Web.API 4.6.0)
Framwork desenvolvido para .NET que permite utilizar no projeto o padrão denominado "Injeção de Dependência", ou seja, no nosso projeto iremos mapear 
quais classes deverão ser utilizadas para instanciar cada interface que os métodos construtores precisam receber.
Projeto.Services

Nesta classe iremos utilizar o método Application_Start para configurar o SimpleInjector no momento da inicialização do projeto.








