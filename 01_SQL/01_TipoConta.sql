create table TipoConta (
id int auto_increment primary key
,descricao varchar(50) not null
);
/****************************************************************************************
CARGA DA TABELA
*****************************************************************************************/
INSERT INTO TipoConta (descricao) VALUES ('BASICO');
INSERT INTO TipoConta (descricao) VALUES ('SACIONAL');
INSERT INTO TipoConta (descricao) VALUES ('MENSAL');