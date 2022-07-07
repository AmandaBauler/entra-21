CREATE TABLE pessoas(nome VARCHAR(100), 
	cpf VARCHAR(14), 
	rg VARCHAR(12), 
	data_nascimento DATETIME2, 
	idade INTEGER
);

INSERT INTO pessoas(nome, cpf, rg, data_nascimento, idade)
	VALUES('Erick Bryan Enrico Vieira', '699.734.958-70', 
	'90.745.276-0', '1989-05-28', 29);
INSERT INTO pessoas(nome, cpf, rg, data_nascimento, idade)
	VALUES('Samuel Ruan Dias', '802.790.194-40', 
	'55.318.691-7', '08/02/1988 1988-02-08', 30);
--MODIFICAR PARA OS NOMES CORRETOS
INSERT INTO pessoas(nome, cpf, rg, data_nascimento, idade)
	VALUES('Erick Bryan Enrico Vieira', '699.734.958-70', 
	'90.745.276-0', '1989-05-28', 29);
INSERT INTO pessoas(nome, cpf, rg, data_nascimento, idade)
	VALUES('Erick Bryan Enrico Vieira', '699.734.958-70', 
	'90.745.276-0', '1989-05-28', 29);

SELECT nome, cpf, rg, data_nascimento, idade
	FROM pessoas;