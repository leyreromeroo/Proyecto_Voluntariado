
USE MASTER

IF� EXISTS (SELECT * FROM sys.databases WHERE NAME = 'PROYECTO_VOLUNTARIADO2')
	BEGIN	
	DROP DATABASE 'PROYECTO_VOLUNTARIADO2';
END
GO
CREATE DATABASE PROYECTO_VOLUNTARIADO2
GO
USE PROYECTO_VOLUNTARIADO2

-- TABLA TIPO DE ACTIVIDAD
CREATE TABLE TIPO_ACTIVIDAD (
    NOMBRE NVARCHAR(20) NOT NULL,
    CONSTRAINT PK_TIPO_ACTIVIDAD PRIMARY KEY (NOMBRE)
);

-- TABLA VOLUNTARIO
CREATE TABLE VOLUNTARIO (
    DNI NVARCHAR(9) NOT NULL,
    NOMBRE NVARCHAR(20) NOT NULL,
    APELLIDO1 NVARCHAR(20) NOT NULL,
    APELLIDO2 NVARCHAR(20),
    EMAIL NVARCHAR(100) NOT NULL,
    FECHANACI DATE NOT NULL,
    DIRECCION NVARCHAR(100) NOT NULL,
    CONSTRAINT PK_VOLUNTARIO PRIMARY KEY (DNI)
);


-- TABLA ORGANIZACIONES
CREATE TABLE ORGANIZACIONES (
    NIF NVARCHAR(9) NOT NULL,
    NOMBRE NVARCHAR(50) NOT NULL,
    TELEFONO VARCHAR(20),
    LOCALIDAD NVARCHAR(50),
    CONSTRAINT PK_ORGANIZACIONES PRIMARY KEY (NIF)
);

-- TABLA ACTIVIDAD
CREATE TABLE ACTIVIDAD (
    CODACTIVIDAD SMALLINT IDENTITY(1,1) NOT NULL,
    NOMBRE NVARCHAR(50) NOT NULL,
    ESTADO NVARCHAR(10) NOT NULL CHECK (ESTADO IN ('DISPONIBLE', 'COMPLETO')),
    DESCRIPCION TEXT NOT NULL,
    FECHAINICIO DATE NOT NULL CHECK (FECHAINICIO >= GETDATE()),
    FECHAFIN DATE NOT NULL,
    CAPACIDAD INT NOT NULL,
    NIF_ORG NVARCHAR(9) NOT NULL,
    NOMBRE_TIPOACT NVARCHAR(20) NOT NULL,
    CONSTRAINT PK_ACTIVIDAD PRIMARY KEY (CODACTIVIDAD),
    CONSTRAINT FK_ACTIVIDAD_ORG FOREIGN KEY (NIF_ORG) REFERENCES ORGANIZACIONES (NIF),
    CONSTRAINT FK_ACTIVIDAD_TIPO FOREIGN KEY (NOMBRE_TIPOACT) REFERENCES TIPO_ACTIVIDAD (NOMBRE)
);
CREATE UNIQUE INDEX UQ_ACTIVIDAD_NOMBRE ON ACTIVIDAD (NOMBRE);
ALTER TABLE ACTIVIDAD
ADD CONSTRAINT CHK_FECHA_INICIO CHECK (FECHAINICIO >= GETDATE() AND FECHAINICIO <= FECHAFIN);

-- TABLA TEL�FONO
CREATE TABLE TELEFONO (
    DNI NVARCHAR(9) NOT NULL,
    NUMTELF VARCHAR(9) NOT NULL,
    CONSTRAINT PK_TELEFONO PRIMARY KEY (DNI, NUMTELF),
    CONSTRAINT FK_TELEFONO_VOLUNTARIO FOREIGN KEY (DNI) REFERENCES VOLUNTARIO (DNI)
);

-- TABLA DISPONIBILIDAD
CREATE TABLE DISPONIBILIDAD (
    DNI NVARCHAR(9) NOT NULL,
    DIASEMANA NVARCHAR(10) NOT NULL,
    CONSTRAINT PK_DISPONIBILIDAD PRIMARY KEY (DNI, DIASEMANA),
    CONSTRAINT FK_DISPONIBILIDAD_VOLUNTARIO FOREIGN KEY (DNI) REFERENCES VOLUNTARIO (DNI)
);

-- TABLA PARTICIPA ENTRE VOLUNTARIO Y ACTIVIDAD
CREATE TABLE PARTICIPA_VOLUNTARIO_ACTIVIDAD (
    DNI NVARCHAR(9) NOT NULL,
    CODACTIVIDAD SMALLINT NOT NULL,
    CONSTRAINT PK_PARTICIPA PRIMARY KEY (DNI, CODACTIVIDAD),
    CONSTRAINT FK_PARTICIPA_VOLUNTARIO FOREIGN KEY (DNI) REFERENCES VOLUNTARIO (DNI),
    CONSTRAINT FK_PARTICIPA_ACTIVIDAD FOREIGN KEY (CODACTIVIDAD) REFERENCES ACTIVIDAD (CODACTIVIDAD)
);

-- TABLA PREFIERE ENTRE VOLUNTARIO Y TIPO DE ACTIVIDAD
CREATE TABLE PREFIERE_VOLUNTARIO_TIPOACTIVIDAD (
    DNI NVARCHAR(9) NOT NULL,
    NOMBRE_TIPOACT NVARCHAR(20) NOT NULL,
    CONSTRAINT PK_PREFIERE PRIMARY KEY (DNI, NOMBRE_TIPOACT),
    CONSTRAINT FK_PREFIERE_VOLUNTARIO FOREIGN KEY (DNI) REFERENCES VOLUNTARIO (DNI),
    CONSTRAINT FK_PREFIERE_TIPOACT FOREIGN KEY (NOMBRE_TIPOACT) REFERENCES TIPO_ACTIVIDAD (NOMBRE)
);

-- TABLA ODS
CREATE TABLE ODS (
    NUMODS SMALLINT NOT NULL,
    NOMBRE NVARCHAR(50) NOT NULL,
	DESCRIPCI�N NVARCHAR(MAX),
    CONSTRAINT PK_ODS PRIMARY KEY (NUMODS)
);

-- TABLA CONTIENE ENTRE ACTIVIDAD Y ODS
CREATE TABLE CONTIENE_VOLUNTARIADO_ODS (
    CODACTIVIDAD SMALLINT NOT NULL,
    NUMODS SMALLINT NOT NULL,
    CONSTRAINT PK_CONTIENE PRIMARY KEY (CODACTIVIDAD, NUMODS),
    CONSTRAINT FK_CONTIENE_ACTIVIDAD FOREIGN KEY (CODACTIVIDAD) REFERENCES ACTIVIDAD (CODACTIVIDAD),
    CONSTRAINT FK_CONTIENE_ODS FOREIGN KEY (NUMODS) REFERENCES ODS (NUMODS)
);

-- TABLA NOTICIAS
CREATE TABLE NOTICIAS (
    CODNOTICIA SMALLINT IDENTITY(1,1) NOT NULL,
    NOMBRE NVARCHAR(50) NOT NULL,
    TIPO VARCHAR(20),
    FECHAPUBLI DATE NOT NULL,
    CODACTIVIDAD SMALLINT,
    CONSTRAINT PK_NOTICIAS PRIMARY KEY (CODNOTICIA),
    CONSTRAINT FK_NOTICIAS_ACTIVIDAD FOREIGN KEY (CODACTIVIDAD) REFERENCES ACTIVIDAD (CODACTIVIDAD)
);


GO
CREATE RULE TIPO_VOLUNTARIADO AS (@CAMPO IN ('SOCIAL','AMBIENTAL','T�CNICO','EDUCATIVO'))
GO
CREATE RULE NIFS AS (@CAMPO LIKE '[A-Z][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
GO
CREATE RULE DNI AS (@CAMPO LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][A-Z]')
GO
CREATE RULE DIA_SEMANA AS (@CAMPO IN ('LUNES','MARTES','MI�RCOLES','JUEVES','VIERNES','S�BADO','DOMINGO')) 
GO
CREATE RULE REGLA_TIPO_NOTICIA AS (@CAMPO IN('Noticia','Evento','Actividad Nueva','Otro Tipo'))
GO
--BINDRULE NIFS
EXEC SP_BINDRULE NIFS, 'ORGANIZACIONES.NIF'
EXEC SP_BINDRULE NIFS, 'ACTIVIDAD.NIF_ORG'
--BINDRULE DNI
EXEC SP_BINDRULE DNI, 'VOLUNTARIO.DNI'
EXEC SP_BINDRULE DNI, 'TELEFONO.DNI'
EXEC SP_BINDRULE DNI, 'DISPONIBILIDAD.DNI'
EXEC SP_BINDRULE DNI, 'PARTICIPA_VOLUNTARIO_ACTIVIDAD.DNI'
--BINDRULE DIA_SEMANA
EXEC SP_BINDRULE DIA_SEMANA, 'DISPONIBILIDAD.DIASEMANA'
EXEC SP_BINDRULE TIPO_VOLUNTARIADO, 'TIPO_ACTIVIDAD.NOMBRE'

-- TIPOS DE ACTIVIDAD
INSERT INTO TIPO_ACTIVIDAD VALUES('SOCIAL');
INSERT INTO TIPO_ACTIVIDAD VALUES('AMBIENTAL');
INSERT INTO TIPO_ACTIVIDAD VALUES('TECNICO');
INSERT INTO TIPO_ACTIVIDAD VALUES('EDUCATIVO');

-- VOLUNTARIOS
INSERT INTO VOLUNTARIO VALUES('44649843N','MARKEL', 'ALVARADO', 'GARIN', 'markel.alvarado@gmail.com', '2006-09-07', 'Calle Mayor');
INSERT INTO VOLUNTARIO VALUES('12345789A','JAVIER', 'RENZULLI', '', 'renzulli@gmail.com', '2006-12-02', 'Calle Al Hillad');
INSERT INTO VOLUNTARIO VALUES('98765421Z','JAVIER', 'MARTIN', 'FERNANDEZ', 'jmartinf4@gmail.com', '2006-12-08', 'Calle Peque�a');
INSERT INTO VOLUNTARIO VALUES('12378946D','IKER', 'VIGUERA', 'ESCUDERO', 'viguerilla@gmail.com', '2006-08-11', 'Calle Mayor');

-- ORGANIZACIONES
INSERT INTO ORGANIZACIONES VALUES ('B60000000', 'Ayuntamiento de Barcelona', 931234567, 'Barcelona');
INSERT INTO ORGANIZACIONES VALUES ('G60000000', 'Cruz Roja', 919876543, 'Madrid');
INSERT INTO ORGANIZACIONES VALUES ('F60000000', 'Banco de Alimentos', 952345678, 'M�laga');
INSERT INTO ORGANIZACIONES VALUES ('A12345678', 'ONG Sonrisas', 601234567, 'Valencia');

-- ACTIVIDADES
INSERT INTO ACTIVIDAD (NOMBRE, ESTADO, DESCRIPCION, FECHAINICIO, FECHAFIN, CAPACIDAD, NIF_ORG, NOMBRE_TIPOACT)
VALUES 
('Limpieza de playa', 'DISPONIBLE', 'Limpieza de residuos en la playa de la Barceloneta', '2025-10-26', '2025-10-27', 20, 'B60000000', 'AMBIENTAL'),
('Clases de espa�ol', 'COMPLETO', 'Clases de espa�ol para inmigrantes', '2025-11-01', '2025-11-30', 15, 'G60000000', 'EDUCATIVO'),
('Recogida de alimentos', 'DISPONIBLE', 'Recogida de alimentos para familias necesitadas', '2025-11-15', '2025-11-16', 25, 'F60000000', 'SOCIAL'),
('Taller de reciclaje', 'DISPONIBLE', 'Taller para aprender a reciclar en casa', '2025-11-22', '2025-11-22', 12, 'B60000000', 'AMBIENTAL');

-- TEL�FONOS
INSERT INTO TELEFONO VALUES ('44649843N', '600123456');
INSERT INTO TELEFONO VALUES ('12345789A', '601987654');
INSERT INTO TELEFONO VALUES ('98765421Z', '602567890');
INSERT INTO TELEFONO VALUES ('12378946D', '603345678');

-- DISPONIBILIDAD
INSERT INTO DISPONIBILIDAD VALUES ('44649843N', 'Lunes');
INSERT INTO DISPONIBILIDAD VALUES ('12345789A', 'Martes');
INSERT INTO DISPONIBILIDAD VALUES ('98765421Z', 'Mi�rcoles');
INSERT INTO DISPONIBILIDAD VALUES ('12378946D', 'Jueves');

-- PARTICIPA EN ACTIVIDADES
INSERT INTO PARTICIPA_VOLUNTARIO_ACTIVIDAD VALUES ('44649843N', 3);
INSERT INTO PARTICIPA_VOLUNTARIO_ACTIVIDAD VALUES ('12345789A', 4);
INSERT INTO PARTICIPA_VOLUNTARIO_ACTIVIDAD VALUES ('44649843N', 5);
INSERT INTO PARTICIPA_VOLUNTARIO_ACTIVIDAD VALUES ('12378946D', 6);



-- PREFERENCIAS DE TIPO DE ACTIVIDAD (usando valores v�lidos del cat�logo)
INSERT INTO PREFIERE_VOLUNTARIO_TIPOACTIVIDAD VALUES ('44649843N', 'AMBIENTAL');
INSERT INTO PREFIERE_VOLUNTARIO_TIPOACTIVIDAD VALUES ('12345789A', 'EDUCATIVO');
INSERT INTO PREFIERE_VOLUNTARIO_TIPOACTIVIDAD VALUES ('44649843N', 'SOCIAL');
INSERT INTO PREFIERE_VOLUNTARIO_TIPOACTIVIDAD VALUES ('12378946D', 'AMBIENTAL');

INSERT INTO ODS (NUMODS, NOMBRE, DESCRIPCI�N) VALUES 
(1, 'Fin de la pobreza', 'Erradicar la pobreza en todas sus formas y en todo el mundo.'),
(2, 'Hambre cero', 'Poner fin al hambre, lograr la seguridad alimentaria y la mejora de la nutrici�n.'),
(3, 'Salud y bienestar', 'Garantizar una vida sana y promover el bienestar para todos.'),
(4, 'Educaci�n de calidad', 'Garantizar una educaci�n inclusiva, equitativa y de calidad.'),
(5, 'Igualdad de g�nero', 'Lograr la igualdad de g�nero y empoderar a todas las mujeres y ni�as.'),
(6, 'Agua limpia y saneamiento', 'Garantizar la disponibilidad y la gesti�n sostenible del agua y el saneamiento.'),
(7, 'Energ�a asequible y no contaminante', 'Asegurar el acceso a una energ�a asequible, segura, sostenible y moderna.'),
(8, 'Trabajo decente y crecimiento econ�mico', 'Promover el crecimiento econ�mico sostenido, el empleo pleno y productivo.'),
(9, 'Industria, innovaci�n e infraestructura', 'Construir infraestructuras resilientes, promover la industrializaci�n sostenible.'),
(10, 'Reducci�n de las desigualdades', 'Reducir la desigualdad en y entre los pa�ses.'),
(11, 'Ciudades y comunidades sostenibles', 'Lograr que las ciudades sean inclusivas, seguras y sostenibles.'),
(12, 'Producci�n y consumo responsables', 'Garantizar modalidades de consumo y producci�n sostenibles.'),
(13, 'Acci�n por el clima', 'Adoptar medidas urgentes para combatir el cambio clim�tico y sus efectos.'),
(14, 'Vida submarina', 'Conservar y utilizar sosteniblemente los oc�anos y sus recursos.'),
(15, 'Vida de ecosistemas terrestres', 'Gestionar sosteniblemente los bosques y detener la p�rdida de biodiversidad.'),
(16, 'Paz, justicia e instituciones s�lidas', 'Promover sociedades pac�ficas e inclusivas y acceso a la justicia para todos.'),
(17, 'Alianzas para lograr los objetivos', 'Revitalizar la Alianza Mundial para el Desarrollo Sostenible.');


-- RELACI�N ENTRE ACTIVIDADES Y ODS (suponiendo IDs de actividad autoincrementales desde 1) --FALLO
INSERT INTO CONTIENE_VOLUNTARIADO_ODS VALUES (3, 1);
INSERT INTO CONTIENE_VOLUNTARIADO_ODS VALUES (4, 2);
INSERT INTO CONTIENE_VOLUNTARIADO_ODS VALUES (5, 3);
INSERT INTO CONTIENE_VOLUNTARIADO_ODS VALUES (6, 4);

-- NOTICIAS FALLO
INSERT INTO NOTICIAS VALUES ('�xito en la limpieza de la playa', 'Evento', '2023-10-28', 6);
INSERT INTO NOTICIAS VALUES ('Nuevos voluntarios para las clases de espa�ol', 'Noticia', '2023-11-02', 7);
INSERT INTO NOTICIAS VALUES ('Gran recogida de alimentos', 'Evento', '2023-11-17', 8);
INSERT INTO NOTICIAS VALUES ('Taller de reciclaje completo', 'Noticia', '2023-11-23', NULL);

--PROCEDIMIENTOS ALMACENADOS
--ACTUALIZAR EL ESTADO DE UNA ACTIVIDAD
GO	
CREATE PROCEDURE ACTUALIZARESTADOACTIVIDAD
    @NOMBREACTIVIDAD NVARCHAR(10),
    @NUEVOESTADO NVARCHAR(20)
AS
BEGIN
    UPDATE ACTIVIDAD
    SET ACTIVIDAD.ESTADO = @NuevoEstado
    WHERE ACTIVIDAD.NOMBRE = @NOMBREACTIVIDAD
END
GO

--METER A UN VOLUNTARIO EN UNA ACTIVIAD
CREATE PROCEDURE INSCRIBIRVOLUNACTIVIDAD
    @DNI NVARCHAR(9),
    @CODACTIVIDAD SMALLINT
AS
BEGIN
    INSERT INTO PARTICIPA_VOLUNTARIO_ACTIVIDAD (DNI, CODACTIVIDAD)
    VALUES (@DNI, @CODACTIVIDAD);
END;
GO
EXEC INSCRIBIRVOLUNACTIVIDAD '12345678A', 12;
