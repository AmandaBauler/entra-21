CREATE TABLE enderecos (
	id INTEGER PRIMARY KEY,
	estado VARCHAR(2),
	cidade VARCHAR(140),
	bairro VARCHAR(120),
	cep VARCHAR(10),
	logradouro VARCHAR(250),
	numero INTEGER,
	complemento TEXT
);

INSERT INTO enderecos(id, estado, cidade, bairro, cep, logradouro, numero, complemento)
	VALUES(1, 'AC', 'Rio Branco', 'Ayrton Senna', '69.911-866', 
	'Estrada Deputado José Rui da Silveira Lino', 282, 'Casa');

INSERT INTO enderecos(id, estado, cidade, bairro, cep, logradouro, numero, complemento)
	VALUES(2, 'SC', 'Biguaçu', 'Fundos', '88.161-400', 
	' ', 995, ' ');

INSERT INTO enderecos(id, estado, cidade, bairro, cep, logradouro, numero, complemento)
	VALUES(3, 'MG', 'Santa Luiza', 'Padre Miguel', '33.082-050', 
	'Rua Buenos Aires', 371, 'Apartamento');

INSERT INTO enderecos(id, estado, cidade, bairro, cep, logradouro, numero, complemento)
	VALUES(4, 'BA', ' ', 'São Tomé de Paripe', '40.800-361', 
	'Travessa Luiz Hage', 285, ' ');

INSERT INTO enderecos(id, estado, cidade, bairro, cep, logradouro, numero, complemento)
	VALUES(5, 'MG', 'Ipatinga', 'Vila Celeste', ' ', 
	'Rua Antonio Boaventura Batista', 645, ' ');

INSERT INTO enderecos(id, estado, cidade, bairro, cep, logradouro, numero, complemento)
	VALUES(6, 'RS', 'Passo Fundo', 'Nenê Graeff', '99.030-250', 
	' ', 154, ' ');

INSERT INTO enderecos(id, estado, cidade, bairro, cep, logradouro, numero, complemento)
	VALUES(7, 'AM', 'Manaus', 'Petrópolis', '69.079-300', 
	'Rua Coronel Ferreira Sobrinho', 264, 'Fundos');

INSERT INTO enderecos(id, estado, cidade, bairro, cep, logradouro, numero, complemento)
	VALUES(8, 'TO', 'Gurupi', 'Muniz Santana', '77.402-130', 
	'Rua Adelmo Aires Negri', 794, ' ');

INSERT INTO enderecos(id, estado, cidade, bairro, cep, logradouro, numero, complemento)
	VALUES(9, 'AC', ' ', 'Preventório', ' ', 
	'Beco da Ligação II', 212, 'Bloco B');

INSERT INTO enderecos(id, estado, cidade, bairro, cep, logradouro, numero, complemento)
	VALUES(10, 'AP', 'Santana', 'Comercial', '68.925-073', 
	'Rua Caiçoene', 648, ' ');

INSERT INTO enderecos(id, estado, cidade, bairro, cep, logradouro, numero, complemento)
	VALUES(11, 'PB', 'Cabedelo', 'Camalaú', '58.103-052', 
	'Rua Siqueira Campos', 249, ' ');

SELECT id, estado, cidade, bairro, cep, logradouro, numero, complemento
	FROM enderecos;

