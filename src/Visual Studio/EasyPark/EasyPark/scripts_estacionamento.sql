
create database easypark;
go


use easypark;
go

-- 01tb usuarios

create table usuarios (usuarioId int not null primary key identity(1,1),
nome varchar(50) not null,
email varchar(100) not null,
senha varchar(8) not null,
nivelAcesso int not null);

-- 02 tbEstado

create table estados (estadoId int not null primary key identity(1,1),
nomeEstado varchar(2) not null);

-- 03TbPrestadorServicos
create table prestadorServicos (prestadorServicosId int not null primary key identity (1,1),
nomePrestador varchar(50) not null,
nomeServico varchar(70) not null,
horarioFuncionamento varchar(50) not null,
telefonePrestador varchar(12) not null,
endereco varchar(250) not null,
estado int not null,
prestadorCriador int not null,
constraint FK_estadoAtendimento foreign key (estado) references estados(estadoId),
constraint FK_prestadorCriador foreign key (prestadorCriador) references usuarios(usuarioId));



-- 04TbEstacionamento
create table estacionamento (estacionamentoId int not null primary key identity(1,1),
nomeEstacionamento varchar(40) not null,
horarioFuncionamento varchar(30) not null,
endereco varchar(250) not null,
estado int not null,
telefone varchar(12) not null,
totaisVagas int not null,
vagasEletricas int not null,
vagasPreferenciais int not null,
vagasComuns int not null,
usuarioCriador int not null,
constraint fk_estado foreign key (estado) references estados(estadoId),
constraint fk_UsuarioCriador foreign key (usuarioCriador) references usuarios(usuarioId));


-- insert estados

insert into estados(nomeEstado)
values ('AC'),
 ('AL'),
 ('AP'),
 ('AM'),
   ('BA'),
   ('CE'),
   ('DF'),
   ('ES'),
   ('GO'),
   ('MA'),
   ('MT'),
   ('MS'),
   ('MG'),
   ('PA'),
   ('PB'),
   ('PR'),
   ('PE'),
   ('PI'),
   ('RJ'),
   ('RN'),
   ('RS'),
   ('RO'),
   ('RR'),
   ('SC'),
   ('SP'),
   ('SE'),
   ('TO');