USE Master
go
CREATE DATABASE DbTarefa
USE DBTarefa

CREATE TABLE TB_Usuario(
  IDUsu int identity(1,1) primary key,
  Nome varchar(500) not null,
  Senha varchar(150) not null,
)

CREATE TABLE TB_Tarefa (
  IDTarefa int identity(1,1) primary key,
  Descricao varchar(500) not null,
  DataTarefa Datetime not null,
  IDUsu int Foreign Key References TB_Usuario(IDUsu)
)

SELECT * FROM TB_Usuario
SELECT * FROM TB_Tarefa