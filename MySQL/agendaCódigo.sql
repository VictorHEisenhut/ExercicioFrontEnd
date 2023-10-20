/*
create table tb_contatos(
	id int primary key auto_increment,
    nome varchar(45),
    celular int(11)
);

create table tb_locais(
	id int primary key auto_increment,
    bairro varchar(45),
    cidade varchar(45),
    rua varchar(45),
    numero int(10),
    cep int(8)
);


create table tb_compromissos(
	id int primary key auto_increment,
    descricao varchar(120) not null,
    data date not null,
    hora time not null
);

alter table tb_compromissos
add column tb_contatos_id int;

alter table tb_compromissos
add constraint fk_contatos
foreign key(tb_contatos_id)
references tb_contatos(id);

*/
drop table tb_compromissos;

create table tb_compromissos(
	id int primary key auto_increment,
    descricao varchar(100) not null,
    data date not null,
    hora time not null,
    tb_contatos_id int not null,
    tb_locais_id int not null,
    foreign key(tb_contatos_id) references tb_contatos(id),
    foreign key(tb_locais_id) references tb_locais(id)
);