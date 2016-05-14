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
--GO
--CREATE TABLE NOTAS (
--	ID_ALUNO INT FOREIGN KEY REFERENCES ALUNO(ID_ALUNO)
--)
--insert into ALUNO (NOME, EMAIL, SEXO, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE) values ('Jessica Fuller', 'jfuller0@eventbrite.com', 'F', 'Mandrake', '50993', 8, 'Jacksonville', 'Florida', 11);
--insert into ALUNO (NOME, EMAIL, SEXO, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE) values ('Annie Wheeler', 'awheeler1@google.ca', 'F', 'Pawling', '80412', 8, 'Las Vegas', 'Nevada', 11);
--insert into ALUNO (NOME, EMAIL, SEXO, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE) values ('Brandon Murphy', 'bmurphy2@washingtonpost.com', 'M', 'Transport', '5', 8, 'Portland', 'Oregon', 11);
--insert into ALUNO (NOME, EMAIL, SEXO, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE) values ('Douglas Edwards', 'dedwards3@oaic.gov.au', 'M', 'Golf View', '6039', 8, 'Oklahoma City', 'Oklahoma', 11);
--insert into ALUNO (NOME, EMAIL, SEXO, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE) values ('Alan Duncan', 'aduncan4@aol.com', 'M', 'Springs', '67', 8, 'Arlington', 'Virginia', 11);
--insert into ALUNO (NOME, EMAIL, SEXO, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE) values ('Juan Reed', 'jreed5@cbslocal.com', 'M', 'Rockefeller', '4517', 8, 'Amarillo', 'Texas', 11);
--insert into ALUNO (NOME, EMAIL, SEXO, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE) values ('Judy Gilbert', 'jgilbert6@booking.com', 'F', 'Northview', '3346', 8, 'Rochester', 'New York', 11);
--insert into ALUNO (NOME, EMAIL, SEXO, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE) values ('Scott Bishop', 'sbishop7@msn.com', 'M', 'Derek', '01', 8, 'Cincinnati', 'Ohio', 11);
--insert into ALUNO (NOME, EMAIL, SEXO, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE) values ('Bobby Tucker', 'btucker8@amazon.de', 'M', 'Corben', '30', 8, 'Roanoke', 'Virginia', 11);
--insert into ALUNO (NOME, EMAIL, SEXO, RUA, NUM, CEP, CIDADE, ESTADO, TELEFONE) values ('John Wagner', 'jwagner9@intel.com', 'M', 'Truax', '72424', 8, 'Bethesda', 'Maryland', 11);
--GO
INSERT INTO CURSO VALUES (1, 'BASICO')
INSERT INTO CURSO VALUES (2, 'COMPLETO')
INSERT INTO CURSO VALUES (3, 'EXPRESSO')

INSERT INTO PERIODO VALUES (1, 'MANHA')
INSERT INTO PERIODO VALUES (2, 'TARDE')
INSERT INTO PERIODO VALUES (3, 'NOITE')

SELECT * FROM ALUNO
SELECT * FROM FUNCIONARIO
SELECT * FROM PROFESSOR
SELECT * FROM CURSO
SELECT * FROM PERIODO
--SELECT NOME, EMAIL, TELEFONE FROM ALUNO 
--delete from ALUNO where ID_ALUNO = 2


--INSERT INTO ALUNO VALUES ('ERT','ERG','MASC','SWF','ergdrfg', 5, 111111, 'EEF', 'WEF', '213345', 1, 3)
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

----JUNTA ALUNO COM PERIODO E CURSO
--SELECT ALUNO.ID_ALUNO, ALUNO.NOME, CURSO.NOME AS CURSO, PERIODO.NOME AS PERIODO
--FROM ALUNO
--INNER JOIN CURSO
--ON ALUNO.ID_CURSO=CURSO.ID_CURSO
--INNER JOIN PERIODO
--ON ALUNO.ID_PERIODO=PERIODO.ID_PERIODO;


----ALUNO
----PESSOAIS
--SELECT ALUNO.ID_ALUNO AS ID, ALUNO.NOME, ALUNO.SEXO, CURSO.NOME AS CURSO, PERIODO.NOME AS PERIODO FROM ALUNO INNER JOIN CURSO ON ALUNO.ID_CURSO=CURSO.ID_CURSO INNER JOIN PERIODO ON ALUNO.ID_PERIODO=PERIODO.ID_PERIODO

----CONTATO
--SELECT ID_ALUNO AS ID, NOME, EMAIL, TELEFONE FROM ALUNO 

----ENDERECO
--SELECT ID_ALUNO AS ID, NOME, RUA, NUM, CEP, CIDADE, ESTADO FROM ALUNO


----PROFESSOR
----PESSOAIS
--SELECT ID_PROFESSOR AS ID, NOME, SEXO, RG, CPF FROM PROFESSOR

----CONTATO
--SELECT ID_PROFESSOR AS ID, NOME, EMAIL, TELEFONE, CELULAR FROM PROFESSOR

----ENDERECO
--SELECT ID_PROFESSOR AS ID, NOME, RUA, NUM, CEP, CIDADE, ESTADO FROM PROFESSOR



----FUNCIONARIO
----PESSOAIS
--SELECT ID_FUNCIONARIO AS ID, NOME, SEXO, CARGO, RG, CPF FROM FUNCIONARIO

----CONTATO
--SELECT ID_FUNCIONARIO AS ID, NOME, EMAIL, TELEFONE, CELULAR FROM FUNCIONARIO

----ENDERECO
--SELECT ID_FUNCIONARIO AS ID, NOME, RUA, NUM, CEP, CIDADE, ESTADO FROM FUNCIONARIO