create database db_integracionContinua;

use db_integracionContinua;

--drop table tblEstudiantes
CREATE TABLE tblEstudiantes(
	id int identity(1,1),
	identificacion varchar(50) not null,
	nombre varchar(80) not null,
	telefono varchar(30),
	primary key(id)
);

insert into tblEstudiantes values('100722','Juan Esteban Parra Correa','313574');
insert into tblEstudiantes values('100723','Matías Álvarez Hernández','313575');
insert into tblEstudiantes values('100724','Giovanny Zarate Gomez','313576');
insert into tblEstudiantes values('100725','Herbert Emmanuel Otalora','313577');
insert into tblEstudiantes values('100726','Pedro','313578');


CREATE PROCEDURE sp_ObtenerEstudiantes
AS
BEGIN
	SELECT id,identificacion,nombre,telefono from tblEstudiantes
END