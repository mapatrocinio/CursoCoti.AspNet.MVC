RELACIONAMENTO 1 PARA MUITOS

0 - Modelagem de entidades
Biblioteca de Classes .NET Framework

1.1 - Camada de Apresentação
Projeto Asp.Net MVC

	Criando um banco de dados
	MDF - Master Database File
	
	Rodar Scripts para criação das tabelas

	Web.config.xml
	Mapeando a string de conexão com o banco de dados	

1.3 - Camada de Acesso a Dados
Repositório de banco de dados

	Adicionando referencias no projeto: (Projeto.Entities)
	System.Configuration

	Instalando o Dapper: (1.60.6)
	Gerenciador de pacotes do NuGet

1.4 - Camada de Regras de Negócio:
Biblioteca de Classes .NET Framework

	Adicionando referencias: (Projeto.DAL e Projeto.Entiies)


1.5 - Camada de Apresentação

	Adicionando referências no projeto Asp.Net MVC: (Projeto.BLL e Projeto.Entiies)

	Instalando o bootstrap: (4.3.1)

	Criando uma página de layout mestre (Adionar --> Novo página de exibição 
	/Views/Shared/Layout.cshtml

	/Home/Index
	[Controller]    [View]
	Adiocnar --> Controlador MVC 5 (Vazio)
	
	Adicionar Exibição a partir do Método Index do controlador ou de cada método da página
	Referência sempre para ~/Views/Shared/Layout.cshtml
	Irá criar view/ome/Index.cshtml (Método)

	Definir a página defaut do projeto (Projeto-properties --> Web - Página específica - Home/Index)

Depois disso é ir criando as páginas de cadastro...

Criar o controle de funcionários

Adicionar as vies (Cadastro, consulta) de funcionário

Classe de modelo (Model)
Criando uma ViewModel para cadastro de Funcionario
(NESTA PÁGINA ESTÁ CONTIDA AS VALIDAÇÕES DA PÁGINA)

Criando o formulário para cadastro de funcionário contendo por enquanto os campos Nome, Salario e DataAdmissao:
VIEWS/FUNCIONARIO/CADASTRO.SHTML
VIEWS/FUNCIONARIO/CONSULTA.SHTML

FUNCIONARIOCONTROLLER.CS recebe os métodos das páginas httppost

CONTINUA NA AULA 15

Adicionando na classe Model as propriedades 
para gerar os campos DropDownList
/Models/FuncionarioCadastroViewModel.cs

SelectListItem
Classe do Asp.Net MVC utilizada para gerar campos de seleção em formulários como: DropDownList, RadioButtonList, CheckBoxList, etc
Esta classe é composta de 2 propriedades principais: 

⦁	Value: Armazena o valor que será enviado para o servidor quando o campo for selecionado.

⦁	Text: Exibe o texto que é mostrado no campo para o usuario
(Adicionar na classe FuncionarioCadastroViewModel)

Para que a página de cadastro de Funcionario possa exibir os campos DropDownList carregados de forma correta, 
é necessário enviar para a página uma instância da classe FuncionarioCadastroViewModel quando a página for carregada.
(Na página FuncionarioController tem os métodos GET e POST para acionamento da página e post)

CONTINUA NA AULA 16 

AutoMapper (https://automapper.org/) (8.1.0)
Framework para realização de troca de dados entre objetos, iremos utiliza-lo para simplificar a transferencia 
dos dados entre as classes de entidade e viewmodels.

Criando 2 classes para mapear as trocas 
de dados que serão feitas pelo AutoMapper:

\Mappings\ViewModelToEntityMap.cs
Mapeamento das trocas de dados entre ViewModel e Entidades

Para que os mapeamentos feitos no AutoMapper possam funcionar é necessário configura-los na classe Global.asax

Refatoração
Melhoria / Otimização do código-fonte de uma aplicação.


Mapeando os campos com nomes diferentes 
entre as viewmodels e entidades:


















	
