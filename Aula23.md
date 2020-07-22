DDD - Domain Driven Design
Design de projeto orientado a Domínio

É um padrão criado por Eric Evans que define um conjunto de boas práticas para desenvolvimento de projetos onde o foco é o dominio do sistema.

Dominio:
Entende-se por dominio todo o conjunto de entidades, serviços e regras de negócio inerentes a uma área de conhecimento.

Exemplo:

Domínio: Agenda Pessoal

⦁	Entidades:
Contato (IdContato, Nome, Email, Telefone)
Endereco (IdEndereco, Logradouro, Bairro, Cidade, Estado, Cep)
Compromisso (IdCompromisso, Data/Hora, Descricao, Status)
	
	
Passo 1) Criar o domínio:

No padrão DDD, todo projeto deve conter um ou mais domínios e também as seguintes partes:

Apresentação
Parte do projeto que irá disponibilizar a interface do sistema com o usuário final. (WebAPI, MVC, etc..)

Aplicação
Parte do projeto que interliga a apresentação com o dominio

InfraEstrutura
Parte que dá sustentação ao dominio, onde implementamos repositorio de dados, logs, e qualquer tipo de projeto que provenha recursos ao dominio

Domain Services

São classes que deverão prover os serviços e operações realizadas pelo dominio para cada Domain Entity, implementando suas regras de negócio.

Bases (Super Types)
Para o DDD, todo serviço pode ser abstraido atraves de um tipo generico.

Repository Contracts

Nesta parte do dominio serão criadas as interfaces para implementar as classes do repositorio de dados

4 - InfraEstrutura

Parte do sistema DDD destinado a implementar operações de suporte do dominio. Todo projeto feito em DDD terá pelo menos 1 InfraEstrutura destinada 
a implementar o repositorio de dados.

Instalando o EntityFramework (6.2.0)
Gerenciador de pacotes do NuGet

ORM - Mapeamento Objeto / Relacional
Mapear as classes Domain Entities para que sejam 
interpretadas como tabelas do banco de dados.

CONTINUA NA 24

Criando uma conta de hospedagem no site: https://www.myasp.net/
Login mapatrocinio
mapatrocinio@gmail.com
senha: ljx21321

Conta:mapatrocinio-001
DIRETÓRIO RAIS AULA25
FTP: FTP.SITE4NOW.NET
FTP nome do usuário: 	mapatrocinio-001
FTP SEnha: (O mesmo que sua senha do painel de controle)
FTP Diretório: 	\

DB DB_A572C5_AULA24
Nome de Usuário: DB_A572C5_AULA24_admin
Banco de dados: Senha x19701978
"Data Source=SQL5045.site4now.net;Initial Catalog=DB_A572C5_AULA24;User Id=DB_A572C5_AULA24_admin;Password=x19701978;"


enable-migrations -ProjectName Projeto.Infra.Data -force
update-database -verbose -ProjectName Projeto.Infra.Data

CONTINUA NA 25

Camada de aplicação

Aplicação
Consiste de uma "camada" entre 
o Dominio e a Apresentação do sistema.

ViewModels
Classes utilizadas para definir os dados de 
entrada / saida para cada operação da aplicação.



Mapeando as trocas de dados para 
Contato atraves do AutoMapper:


Application Services
Classes da "camada" de aplicação que irão entregar 
para a Apresentação as operações de cada entidade.

CONTINUA NA 26

Publicando o projeto:
Exportando os arquivos de publicação do projeto para uma pasta local

Publicar apenas o Projeto.presentation

Criando uma conta no GitHub (https://github.com/)
Repositório de código (Portfolio de programadores)

mapatrocinio
mapatrocinio@gmail.com
x19701978

https://github.com/mapatrocinio/projeto_DDD.git

Para que possamos fazer o upload do projeto para o GitHub iremos utilizar uma interface de comandos denominada GitBash
https://gitforwindows.org/

git config --global user.name 'mapatrocinio'
git config --global user.email 'mapatrocinio@gmail.com'
git add Aula23.sln
git add Projeto.Presentation
git add Projeto.Application
git add Projeto.Domain
git add Projeto.Infra.Data

git commit -m 'Projeto DDD Informatica'

git remote add origin https://github.com/mapatrocinio/projeto_DDD.git
git push --set-upstream https://github.com/mapatrocinio/projeto_DDD.git master










