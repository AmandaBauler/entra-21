CREATE TABLE champions(
	id INTEGER PRIMARY KEY,
	nome VARCHAR(50),
	descricao VARCHAR(100),
	habilidade_1 VARCHAR(100),
	habilidade_2 VARCHAR(100),
	habilidade_3 VARCHAR(100),
	habilidade_4 VARCHAR(100),
	habilidade_5 VARCHAR(100)
);

INSERT INTO champions(id, nome, descricao, habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5)
	VALUES(1, 'Katarina', 'a Lâmina Sinistra', 'Voracidade', 
	'Lâmina Saltitante', 'Preparação', 'Shunpo', 'Lótus da Morte');

INSERT INTO champions(id, nome, descricao, habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5)
	VALUES(2, 'Yasuo', ' ', 'Estilo do Errante', 'Tempestade de Aço', 
	'Parede de Vento', 'Espada Ágil', 'Último Suspiro');

INSERT INTO champions(id, nome, descricao, habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5)
	VALUES(3, 'Master yi', 'oEspadacim Wuju', 'Ataque Duplo', 
	' ', ' ', ' ', ' ');

INSERT INTO champions(id, nome, descricao, habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5)
	VALUES(4, 'Vayne', 'a Caçadora Noturna', 'Caçadora Noturna', 'Rolamento', 
	'Dardos de Prata', 'Condenar', 'Hora Final');

INSERT INTO champions(id, nome, descricao, habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5)
	VALUES(5, 'Lee Sin', 'o Monge Cego', 'Agitação', 'Onda Sônica/Ataque Ressoante', 
	'Proteger/Vontade de Ferro', 'Tempestade/Mutilar', ' ');

INSERT INTO champions(id, nome, descricao, habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5)
	VALUES(6, 'Vi', 'a Defensora de Piltover', 'Blindagem', ' ', 'Pancada Certeira', 
	'Força Excessiva',	'Saque e Enterrada');

INSERT INTO champions(id, nome, descricao, habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5)
	VALUES(7, 'Diana', 'o Escárnio da Lua', 'Espada de Prata Lunar', 'Golpe Crescente', 
	'Cascata Lívida', 'Colapso Minguante', 'Zênite Lunar');

INSERT INTO champions(id, nome, descricao, habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5)
	VALUES(8, 'Annie', 'a Criança Sombria', 'Piromania', 'Desintegrar',
	'Incinerar', 'Escudo Fundido', 'Invocar Tibbers');

INSERT INTO champions(id, nome, descricao, habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5)
	VALUES(9, 'Aatrox', ' ', 'Poço de Sangue', 'Voo Sombrio', 
	'Sede de Sangue/Preço em Sangue', 'Laminas de Aflição', 'Massacre');

SELECT id, nome, descricao, habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5
	FROM champions;