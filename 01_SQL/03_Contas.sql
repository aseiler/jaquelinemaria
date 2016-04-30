create table contas (
id int auto_increment primary key
,Descricao varchar(100) not null
,idtipo int not null
,idestado int not null
,foreign key (idtipo) references TipoConta(id)
,foreign key (idestado) references EstadoConta(id)
)
