USE MASTER
GO

IF EXISTS(SELECT * FROM SYSDATABASES WHERE NAME = 'AALVES')
	DROP DATABASE AALVES
GO

CREATE DATABASE AALVES
GO
USE AALVES
GO
CREATE TABLE CURSO (
	ID_CURSO INT PRIMARY KEY,
	NOME VARCHAR(50) NOT NULL
)
GO
CREATE TABLE PERIODO (
	ID_PERIODO INT PRIMARY KEY,
	NOME VARCHAR(50) NOT NULL
)
GO
CREATE TABLE ALUNO (
	ID_ALUNO INT PRIMARY KEY IDENTITY(1,1),
	NOME VARCHAR(80) NOT NULL,
	EMAIL VARCHAR(80) NOT NULL,
	SEXO VARCHAR(20) NOT NULL,
	SENHA VARCHAR(80) NOT NULL,
	RUA VARCHAR(80) NOT NULL,
	NUM INT NOT NULL,
	CEP VARCHAR(9) NOT NULL,
	CIDADE VARCHAR(50) NOT NULL,
	ESTADO VARCHAR(30) NOT NULL,
	TELEFONE VARCHAR(20) NOT NULL,
	ID_CURSO INT FOREIGN KEY REFERENCES CURSO(ID_CURSO),
	ID_PERIODO INT FOREIGN KEY REFERENCES PERIODO(ID_PERIODO)
)
GO
CREATE TABLE PROFESSOR (
	ID_PROFESSOR INT PRIMARY KEY IDENTITY(1,1),
	NOME VARCHAR(80) NOT NULL,
	SEXO VARCHAR(20) NOT NULL,
	RG VARCHAR(50) NOT NULL,
	CPF VARCHAR (50) NOT NULL,
	RUA VARCHAR (80) NOT NULL,
	NUM INT NOT NULL,
	BAIRRO VARCHAR(20) NOT NULL,
	CEP VARCHAR(9) NOT NULL,
	CIDADE VARCHAR(50) NOT NULL,
	ESTADO VARCHAR(30) NOT NULL,
	TELEFONE VARCHAR(20) NOT NULL,
	CELULAR VARCHAR (20) NOT NULL,
	EMAIL VARCHAR(80) NOT NULL,
	SENHA VARCHAR (80) NOT NULL
)
GO
CREATE TABLE FUNCIONARIO (
	ID_FUNCIONARIO INT PRIMARY KEY IDENTITY(1,1),
	NOME VARCHAR(80) NOT NULL,
	SEXO VARCHAR(20) NOT NULL,
	RG VARCHAR(50) NOT NULL,
	CPF VARCHAR (50) NOT NULL,
	RUA VARCHAR (80) NOT NULL,
	NUM INT NOT NULL,
	BAIRRO VARCHAR(20) NOT NULL,
	CEP VARCHAR(9) NOT NULL,
	CIDADE VARCHAR(50) NOT NULL,
	ESTADO VARCHAR(30) NOT NULL,
	TELEFONE VARCHAR(20) NOT NULL,
	CELULAR VARCHAR (20) NOT NULL,
	EMAIL VARCHAR(80) NOT NULL,
	SENHA VARCHAR (80) NOT NULL,
	CARGO VARCHAR(80)
)
CREATE TABLE ATIVIDADE (
	ID_ATIV INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	NOME VARCHAR(40) NOT NULL,
	DESCRICAO VARCHAR(100) NOT NULL,
	ID_PROFESSOR INT FOREIGN KEY REFERENCES PROFESSOR(ID_PROFESSOR),
)
GO

CREATE TABLE NOTA (
	ID_NOTA INT NOT NULL IDENTITY(1,1),
	ID_ATIV INT FOREIGN KEY REFERENCES ATIVIDADE(ID_ATIV),
	ID_ALUNO INT FOREIGN KEY REFERENCES ALUNO(ID_ALUNO),
	VALOR INT NOT NULL
)
GO

INSERT INTO CURSO VALUES (1, 'BASICO')
INSERT INTO CURSO VALUES (2, 'INTERMEDIARIO')
INSERT INTO CURSO VALUES (3, 'AVANCADO')
INSERT INTO CURSO VALUES (4, 'EXPRESSO')

INSERT INTO PERIODO VALUES (1, 'MANHA')
INSERT INTO PERIODO VALUES (2, 'TARDE')
INSERT INTO PERIODO VALUES (3, 'NOITE')
GO

INSERT INTO PROFESSOR VALUES ('JOÃO', 'M', '552713237', '221.897.532.09', 'ERWCD', 323, 'LELEL', '35874658', 'LELEL', 'LELEL', 'LELEL', 'LELEL', 'joao@esc.com', '12345')
INSERT INTO FUNCIONARIO VALUES ('MARIA', 'LELELE', 'M', 'LELEL', 'LELEL', 323, 'LELEL', '35874658', 'LELEL', 'LELEL', 'LELEL', '1234', 'maria@esc.com', '12345', 'Gerente')
INSERT INTO FUNCIONARIO VALUES ('CARLOS', 'LELELE', 'M', 'LELEL', 'LELEL', 323, 'LELEL', '35874658', 'LELEL', 'LELEL', 'LELEL', 'LELEL', 'carlos@esc.com', '12345', 'Funcionario')
GO

insert into ALUNO (NOME, EMAIL, SEXO, SENHA, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE, ID_CURSO, ID_PERIODO) values ('Adam Kim', 'akim0@webs.com', 'Male', 'akim0', 'Oxford', '5', 38739564, 'Rockford', 'IL', '1-(815)782-0736', 2, 3);
insert into ALUNO (NOME, EMAIL, SEXO, SENHA, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE, ID_CURSO, ID_PERIODO) values ('Jeremy Cook', 'jcook1@ibm.com', 'Male', 'jcook1', 'Rigney', '04', 36317543, 'Washington', 'DC', '1-(202)420-9860', 3, 1);
insert into ALUNO (NOME, EMAIL, SEXO, SENHA, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE, ID_CURSO, ID_PERIODO) values ('Samuel Ferguson', 'sferguson2@infoseek.co.jp', 'Male', 'sferguson2', 'Donald', '09345', 31215011, 'Detroit', 'MI', '1-(313)553-4587', 1, 3);
insert into ALUNO (NOME, EMAIL, SEXO, SENHA, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE, ID_CURSO, ID_PERIODO) values ('Lisa Lawrence', 'llawrence3@behance.net', 'Female', 'llawrence3', 'Michigan', '613', 18920891, 'Fort Wayne', 'IN', '1-(260)385-0754', 1, 1);
insert into ALUNO (NOME, EMAIL, SEXO, SENHA, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE, ID_CURSO, ID_PERIODO) values ('Beverly Baker', 'bbaker4@wufoo.com', 'Female', 'bbaker4', 'Daystar', '8', 37580646, 'Sacramento', 'CA', '1-(916)594-6439', 2, 2);
insert into ALUNO (NOME, EMAIL, SEXO, SENHA, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE, ID_CURSO, ID_PERIODO) values ('Christine Barnes', 'cbarnes5@google.nl', 'Female', 'cbarnes5', 'Continental', '0105', 34752977, 'Virginia Beach', 'VA', '1-(757)692-7407', 3, 3);
insert into ALUNO (NOME, EMAIL, SEXO, SENHA, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE, ID_CURSO, ID_PERIODO) values ('Deborah Hicks', 'dhicks6@engadget.com', 'Female', 'dhicks6', 'South', '8', 22929524, 'Sacramento', 'CA', '1-(530)337-0347', 3, 2);
insert into ALUNO (NOME, EMAIL, SEXO, SENHA, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE, ID_CURSO, ID_PERIODO) values ('Emily Bennett', 'ebennett7@nydailynews.com', 'Female', 'ebennett7', 'Claremont', '78807', 48383144, 'North Las Vegas', 'NV', '1-(702)500-1597', 2, 3);
insert into ALUNO (NOME, EMAIL, SEXO, SENHA, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE, ID_CURSO, ID_PERIODO) values ('Douglas Ortiz', 'dortiz8@mit.edu', 'Male', 'dortiz8', 'Westerfield', '53204', 92617708, 'Saint Paul', 'MN', '1-(651)759-7954', 1, 1);
insert into ALUNO (NOME, EMAIL, SEXO, SENHA, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE, ID_CURSO, ID_PERIODO) values ('Kevin Simpson', 'ksimpson9@last.fm', 'Male', 'ksimpson9', 'Ridgeview', '0519', 46663967, 'Greensboro', 'NC', '1-(336)757-8310', 1, 2);
insert into ALUNO (NOME, EMAIL, SEXO, SENHA, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE, ID_CURSO, ID_PERIODO) values ('Nicole Lynch', 'nlyncha@pinterest.com', 'Female', 'nlyncha', 'Beilfuss', '88', 56352352, 'Columbia', 'MO', '1-(573)806-6370', 3, 1);
insert into ALUNO (NOME, EMAIL, SEXO, SENHA, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE, ID_CURSO, ID_PERIODO) values ('Ruby Torres', 'rtorresb@posterous.com', 'Female', 'rtorresb', 'Kinsman', '4', 87960968, 'Port Charlotte', 'FL', '1-(941)734-1864', 1, 1);
insert into ALUNO (NOME, EMAIL, SEXO, SENHA, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE, ID_CURSO, ID_PERIODO) values ('Helen Murray', 'hmurrayc@indiegogo.com', 'Female', 'hmurrayc', 'Laurel', '48', 58056353, 'Aurora', 'CO', '1-(303)575-0677', 3, 2);
insert into ALUNO (NOME, EMAIL, SEXO, SENHA, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE, ID_CURSO, ID_PERIODO) values ('Adam Banks', 'abanksd@rediff.com', 'Male', 'abanksd', 'Miller', '088', 78722689, 'Albuquerque', 'NM', '1-(505)515-5720', 2, 1);
insert into ALUNO (NOME, EMAIL, SEXO, SENHA, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE, ID_CURSO, ID_PERIODO) values ('Eric Lynch', 'elynche@icq.com', 'Male', 'elynche', 'Moulton', '57616', 29477847, 'San Antonio', 'TX', '1-(210)114-3960', 3, 3);
insert into ALUNO (NOME, EMAIL, SEXO, SENHA, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE, ID_CURSO, ID_PERIODO) values ('James Wright', 'jwrightf@oracle.com', 'Male', 'jwrightf', 'Hauk', '8', 20279212, 'Topeka', 'KS', '1-(785)671-8085', 2, 2);
insert into ALUNO (NOME, EMAIL, SEXO, SENHA, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE, ID_CURSO, ID_PERIODO) values ('Bruce Burton', 'bburtong@umn.edu', 'Male', 'bburtong', 'Farragut', '6456', 89282976, 'Sioux Falls', 'SD', '1-(605)783-6148', 3, 3);
insert into ALUNO (NOME, EMAIL, SEXO, SENHA, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE, ID_CURSO, ID_PERIODO) values ('Carol Harper', 'charperh@mapy.cz', 'Female', 'charperh', 'School', '862', 92639682, 'Waterbury', 'CT', '1-(203)757-1379', 1, 3);
insert into ALUNO (NOME, EMAIL, SEXO, SENHA, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE, ID_CURSO, ID_PERIODO) values ('Helen Alvarez', 'halvarezi@mysql.com', 'Female', 'halvarezi', 'Crest Line', '407', 14643339, 'Glendale', 'AZ', '1-(623)178-6095', 1, 3);
insert into ALUNO (NOME, EMAIL, SEXO, SENHA, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE, ID_CURSO, ID_PERIODO) values ('James Porter', 'jporterj@pinterest.com', 'Male', 'jporterj', 'Kenwood', '90', 88088015, 'Killeen', 'TX', '1-(254)347-8766', 3, 1);

GO

SELECT * FROM ALUNO
SELECT * FROM FUNCIONARIO
SELECT * FROM PROFESSOR
SELECT * FROM CURSO
SELECT * FROM PERIODO

--SELECT PROFESSOR.NOME AS PROFESSOR, ATIVIDADE.NOME AS ATIVIDADE, NOTA.VALOR AS NOTA FROM PROFESSOR
--INNER JOIN ATIVIDADE ON PROFESSOR.ID_PROFESSOR = ATIVIDADE.ID_PROFESSOR
--INNER JOIN NOTA ON ATIVIDADE.ID_ATIV = NOTA.ID_ATIV

SELECT @@servicename