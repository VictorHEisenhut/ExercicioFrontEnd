use agenda_n_n;


create table tb_contatos(
	id int primary key auto_increment,
    nome varchar(45) not null,
    email varchar(45),
    celular int(11) not null
);

create table tb_locais(
	id int primary key auto_increment,
    nome varchar(45),
    bairro varchar(45),
    cidade varchar(45),
    rua varchar(45),
    numero int(10),
    cep int(8)
);

create table compromisso_contatos(
	compromisso_id int not null,
    contato_id int not null
);

create table tb_compromissos(
	id int primary key auto_increment,
    descricao varchar(120) not null,
    data date not null,
    hora time not null
);

insert into tb_compromissos(descricao, data, hora)
values('Truco', '2023-10-21', '20:00:00');
insert into tb_compromissos(descricao, data, hora)
values('Comer sushi', '2023-10-21', '22:00:00');

insert into tb_contatos(nome, email, celular)
values('jamal', 'jamal@gmail.com', '992802334'), ('kleber', 'kleber@gmail.com', '992803025');

insert into tb_locais(nome, bairro, cidade, rua, numero, cep) 
values('casa do victor', 'quintino', 'Timbó', 'botuverá', '190', '89120000');

insert into tb_compromissos(descricao, data, hora)
values('Tomar banho de piscina', '2023-10-21', '18:00:00');

update tb_compromissos set tb_locais_id = 1 where id = 1;
update tb_compromissos set tb_locais_id = 1 where id = 2;
update tb_compromissos set tb_locais_id = 1 where id = 3;

alter table compromisso_contatos add constraint fk_compromissos foreign key(compromisso_id) references tb_compromissos(id);
alter table compromisso_contatos add constraint fk_contatos foreign key(contato_id) references tb_contatos(id);

insert into compromisso_contatos(compromisso_id, contato_id) 
values(3, 1);


select * from compromisso_contatos;

alter table tb_compromissos add column tb_locais_id int;
alter table tb_compromissos add constraint fk_locais foreign key(tb_locais_id) references tb_locais(id);

select descricao, data, hora, tb_contatos.nome, tb_locais.nome 
from compromisso_contatos, tb_compromissos, tb_contatos, tb_locais
where compromisso_contatos.contato_id = tb_contatos.id && compromisso_contatos.compromisso_id = tb_compromissos.id && tb_compromissos.tb_locais_id = tb_locais.id

