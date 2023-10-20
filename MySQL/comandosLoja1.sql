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


/* Criando tabelas n para n  */

/* Criando fk para tabelas */

/* Criando fk para tabelas n para n */

/* Inserir dados */

