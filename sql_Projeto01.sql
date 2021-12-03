use BD040684

select * from Estado

select * from Cliente

select * from Cidade

select * from BARBEIRO

Select * from ESPECIALIDADE_B

CREATE TABLE CIDADE (

	IdCidade int not null,
	Nome varchar(200) not null,
	Uf char (2) not null,
	

)

alter table cidade 
add constraint PK_CIDADE_ESTADO foreign key (uf) references Estado (uf)

alter table cidade
add constraint PK_CIDADE primary key(IdCidade)

alter table CLIENTE
add constraint FK_CIDADE_CLIENTE foreign key (IdCidade) REFERENCES cidade(IdCidade)

CREATE TABLE BARBEIRO(

	IdBarbeiro int not null,
	Nome varchar(200) not null,
	Cpf char(11) not null,
	PrecoCorte decimal(5 ,2) not null,
	Telefone varchar(20) not null,
	IdEspecialidade int not null


)
alter table barbeiro
add constraint PK_BARBEIRO PRIMARY KEY (IdBarbeiro)

CREATE TABLE ESPECIALIDADE_B(

	IdEspecialidade int not null ,
	Especialidade varchar(200) not null,

)


alter table ESPECIALIDADE_B
add constraint PK_ESPECIALIDADE_B PRIMARY KEY (IdEspecialidade)


insert into Cliente(IdCliente, Nome , Cpf , Sexo, Telefone, cep ,logradouro, complemento, bairro, numero,idCidade )
values(1, 'guina', '15314535629', 'm', '88259161', '38181104', 'rua antonio', 'antiga 107','salomao', '130', 1)

insert into CIDADE (IdCidade, Nome, Uf)
values(1, 'Araxa', 'mg')


insert into CIDADE (IdCidade, Nome, Uf)
values(3, 'perdizes', 'se')
	
insert into estado (Nome, uf)
values('sergipe', 'Se')

