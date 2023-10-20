use aulacsharp;

insert into tb_contatos(nome, celular)
values ('jamal', '(47)99280-4065');

alter table tb_contatos drop column celular;

alter table tb_contatos add column celular varchar(14);

select * from tb_contatos;

insert into tb_locais(bairro, cidade, rua, numero, cep)
values ('Quintino', 'Timbó', 'Botuverá', '123', '89120000');

select * from tb_locais;

insert into tb_compromissos(descricao, data, hora, tb_contatos_id, tb_locais_id)
values ('Jogo do vasco', '2023-10-18', '17:00:00', 1, 1);

select * from tb_compromissos;

select descricao, data, hora, nome, rua 
from tb_compromissos, tb_contatos, tb_locais
where tb_compromissos.tb_contatos_id = tb_contatos.id && tb_compromissos.tb_locais_id = tb_locais.id