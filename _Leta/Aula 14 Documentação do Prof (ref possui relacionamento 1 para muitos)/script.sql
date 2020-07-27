create table Setor(
	IdSetor			integer			identity(1,1),
	Nome			nvarchar(100)	not null,
	primary key(IdSetor))

insert into Setor(Nome) values('Recursos Humanos')
insert into Setor(Nome) values('Desenvolvimento de Sistemas')
insert into Setor(Nome) values('Contabilidade')
insert into Setor(Nome) values('Engenharia de Produção')

create table Funcao(
	IdFuncao		integer			identity(1,1),
	Nome			nvarchar(100)	not null,
	primary key(IdFuncao))

insert into Funcao(Nome) values('Estagiario')
insert into Funcao(Nome) values('Gerente')
insert into Funcao(Nome) values('Supervisor')
insert into Funcao(Nome) values('Operacional')
insert into Funcao(Nome) values('Analista')

create table Funcionario(
	IdFuncionario	integer			identity(1,1),
	Nome			nvarchar(150)	not null,
	Salario			decimal(18,2)	not null,
	DataAdmissao	date			not null,
	IdSetor			integer			not null,
	IdFuncao		integer			not null,
	primary key(IdFuncionario),
	foreign key(IdSetor) references Setor(IdSetor),
	foreign key(IdFuncao) references Funcao(IdFuncao))
