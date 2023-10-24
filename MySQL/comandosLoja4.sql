use lojadb;

/* Criando tabelas */

CREATE TABLE tb_produtos(
	id int primary key auto_increment,
    nome_produto varchar(45) not null
); 

CREATE TABLE tb_clientes(
	id int primary key auto_increment,
    nome varchar(45) not null,
    email varchar(45),
    telefone varchar(14)
);

CREATE TABLE tb_fornecedores(
	id int primary key auto_increment,
    nome_fornecedor varchar(45) not null,
    telefone_fornecedor varchar(14) not null
);

CREATE TABLE tb_categorias(
	id int primary key auto_increment,
    categoria varchar(45)
);

CREATE TABLE tb_pagar(
	id int primary key auto_increment,
    valor decimal not null,
    parcelas int not null,
    data_vencimento date,
    duplicata varchar(45)
);

CREATE TABLE tb_compras_efetuadas(
	id int primary key auto_increment
);

CREATE TABLE tb_formas_pagamento(
	id int primary key auto_increment,
    forma varchar(45) not null
);

CREATE TABLE tb_a_receber(
	id int primary key auto_increment,
    preco varchar(45) not null,
    data_vencimento date,
    parcelas int not null
);

CREATE TABLE tb_vendas_realizadas(
	id int primary key auto_increment
);

/* Criando tabelas n para n  */

CREATE TABLE tb_produtos_tb_fornecedores(
	valor varchar(45)
);

CREATE TABLE tb_produtos_tb_compras_efetuadas(
	quantidade varchar(45),
    valor varchar(45)
);

CREATE TABLE tb_produtos_tb_vendas_realizadas(
	quantidade varchar(45),
    valor_unitario varchar(45)
);


/* Criando fk para tabelas */

ALTER TABLE tb_a_receber ADD COLUMN tb_formas_pagamento_id int; 
ALTER TABLE tb_a_receber ADD CONSTRAINT fk_formas_pagamento FOREIGN KEY(tb_formas_pagamento_id) REFERENCES tb_formas_pagamento(id);

ALTER TABLE tb_compras_efetuadas ADD COLUMN tb_fornecedores_id int; 
ALTER TABLE tb_compras_efetuadas ADD CONSTRAINT fk_fornecedores FOREIGN KEY(tb_fornecedores_id) REFERENCES tb_fornecedores(id);

ALTER TABLE tb_compras_efetuadas ADD COLUMN tb_pagar_id int; 
ALTER TABLE tb_compras_efetuadas ADD CONSTRAINT fk_pagar FOREIGN KEY(tb_pagar_id) REFERENCES tb_pagar(id);

ALTER TABLE tb_pagar ADD COLUMN tb_formas_pagamento_p_id int; 
ALTER TABLE tb_pagar ADD CONSTRAINT fk_formas_pagamento_p FOREIGN KEY(tb_formas_pagamento_id) REFERENCES tb_formas_pagamento(id);

ALTER TABLE tb_produtos ADD COLUMN tb_categorias_id int; 
ALTER TABLE tb_produtos ADD CONSTRAINT fk_categorias FOREIGN KEY(tb_categorias_id) REFERENCES tb_categorias(id);

ALTER TABLE tb_vendas_realizadas ADD COLUMN tb_vendas_realizadas_id int; 
ALTER TABLE tb_vendas_realizadas ADD CONSTRAINT fk_vendas_realizadas FOREIGN KEY(tb_vendas_realizadas_id) REFERENCES tb_vendas_realizadas(id);

/* Criando fk para tabelas n para n */

ALTER TABLE tb_produtos_tb_vendas_realizadas ADD COLUMN tb_produtos_id int; 
ALTER TABLE tb_produtos_tb_vendas_realizadas ADD CONSTRAINT fk_produtos FOREIGN KEY(tb_produtos_id) REFERENCES tb_produtos(id);

ALTER TABLE tb_produtos_tb_vendas_realizadas ADD COLUMN tb_vendas_realizadas_id int; 
ALTER TABLE tb_produtos_tb_vendas_realizadas ADD CONSTRAINT fk_vendas_realizadas_p FOREIGN KEY(tb_vendas_realizadas_id) REFERENCES tb_vendas_realizadas(id);


ALTER TABLE tb_produtos_tb_fornecedores ADD COLUMN tb_produtos_f_id int; 
ALTER TABLE tb_produtos_tb_fornecedores ADD CONSTRAINT fk_produtos_f FOREIGN KEY(tb_produtos_f_id) REFERENCES tb_produtos(id);

ALTER TABLE tb_produtos_tb_fornecedores ADD COLUMN tb_fornecedores_p_id int; 
ALTER TABLE tb_produtos_tb_fornecedores ADD CONSTRAINT fk_fornecedores_p FOREIGN KEY(tb_fornecedores_p_id) REFERENCES tb_fornecedores(id);


ALTER TABLE tb_produtos_tb_compras_efetuadas ADD COLUMN tb_compras_efetuadas_id int; 
ALTER TABLE tb_produtos_tb_compras_efetuadas ADD CONSTRAINT fk_compras_efetuadas_p FOREIGN KEY(tb_compras_efetuadas_id) REFERENCES tb_compras_efetuadas(id);

ALTER TABLE tb_produtos_tb_compras_efetuadas ADD COLUMN tb_produtos_c_id int; 
ALTER TABLE tb_produtos_tb_compras_efetuadas ADD CONSTRAINT fk_produtos_c FOREIGN KEY(tb_produtos_c_id) REFERENCES tb_produtos(id);


ALTER TABLE tb_pagar DROP COLUMN duplicata;
ALTER TABLE tb_pagar DROP COLUMN tb_formas_pagamento_p_id;

/* Inserir dados */

INSERT INTO tb_categorias(categoria) VALUES ("Bebidas"),("Comidas"),("Eletrônicos");

INSERT INTO tb_clientes(nome, email, telefone) VALUES 
("Jamal", "jamal@gmail.com", "(47)995806025"),
("Giulia", "giulia@gmail.com", "(47)991469374"),
("Kleber", "kleber@gmail.com", "(47)996389384");

INSERT INTO tb_compras_efetuadas(tb_fornecedores_id, tb_pagar_id) VALUES ();

INSERT INTO tb_formas_pagamento(forma) VALUES ("Débito"),("Crédito"),("Pix"),("Dinheiro");

INSERT INTO tb_fornecedores(nome_fornecedor, telefone_fornecedor) VALUES 
("Jamal distribuições", "(47)33829364"),("Oliver alimentos", "(47)33829503"),("Giseli eletrônicos","(47)992354393");

INSERT INTO tb_pagar(tb_formas_pagamento_id, valor, parcelas, data_vencimento) 
VALUES (1, 22, 1, "2023-10-25"), (2, 199.90, 3, "2023-10-31"), (4, 50, 1, "2023-10-24");
