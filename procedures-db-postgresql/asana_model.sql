
##
##					Final
##

CREATE TABLE Usuario(
	id_usuario				VARCHAR (50) 	PRIMARY KEY,
	nombre					VARCHAR (50)	CHECK(LENGTH(nombre) > 1),
	usuario					VARCHAR (50)	NOT NULL,
	clave					VARCHAR (255)	NOT NULL,
	correo					VARCHAR (100)	NOT NULL,
	isAdministrador			Boolean			DEFAULT FALSE
);

CREATE TABLE Proyecto (
  "id_proyecto" 				NUMERIC 		PRIMARY KEY,
  "id_administrador" 			VARCHAR (50)	NOT NULL,
  "nombre" 						VARCHAR (50)
);


CREATE TABLE MiembroPorProyecto(
	"id_usuario"				VARCHAR (50) 	REFERENCES Usuario,
	"id_proyecto"				NUMERIC 		REFERENCES Proyecto,
	PRIMARY KEY (id_usuario, id_proyecto)
);


CREATE TABLE public.tareaporseccion
(
    id_seccion numeric NOT NULL,
    id_tarea numeric NOT NULL
)

CREATE TABLE public.tarea
(
    id_tarea 			numeric NOT NULL,
    "idEncargado" 		character varying(50) COLLATE pg_catalog."default",
    "fchFinalizacion" 	date,
    "fchEntrega" 		date,
    nombre 				character varying(50) COLLATE pg_catalog."default",
    nota 				character varying(255) COLLATE pg_catalog."default",
    id_proyecto 		numeric NOT NULL,
    "id_tareaPadre" character varying COLLATE pg_catalog."default",
    CONSTRAINT tarea_pkey PRIMARY KEY (id_tarea)
);

CREATE TABLE TareaPorProyecto (
  id_proyecto 					NUMERIC			REFERENCES Proyecto,
  id_tarea 						NUMERIC			REFERENCES Tarea
);

CREATE TABLE Avance (
  id_avance 					NUMERIC			PRIMARY KEY,
  fecha 						DATE 			NOT NULL,
  horasDedicadas 				NUMERIC,
  descripcion 					VARCHAR(200),
  creador 						VARCHAR(50)		NOT NULL
);

CREATE TABLE AvancePorTarea (
  id_tarea 						NUMERIC			REFERENCES Tarea,
  id_avance 					NUMERIC			REFERENCES Avance
);

CREATE TABLE EvidenciaPorAvance (
  id_avance 					NUMERIC			REFERENCES Avance,	
  tipo							VARCHAR(10),
  documento						bytea			NOT NULL
);

CRE


CREATE TABLE SeguidorPorTarea (
  id_usuario 					VARCHAR (50) 	REFERENCES Usuario,
  id_tarea 						NUMERIC			REFERENCES Tarea,
  PRIMARY KEY(id_usuario, id_tarea)
);


INSERT INTO Proyecto VALUE(14, 'ayuwoki', 'FriendLines');