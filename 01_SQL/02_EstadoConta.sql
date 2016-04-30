create table EstadoConta (
id int auto_increment primary key
,descricao varchar(50) not null
);

/******************************************************************
Carga da tabela
*******************************************************************/
INSERT INTO EstadoConta (descricao) VALUES ('Em Aberto');
INSERT INTO EstadoConta  (descricao) VALUES ('Pago');
