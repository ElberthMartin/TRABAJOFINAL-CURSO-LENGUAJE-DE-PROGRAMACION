DROP TABLE MatriculaSecundaria;

CREATE TABLE MatriculaSecundaria
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    PrimerNombre VARCHAR(255),
    Grado VARCHAR(255) DEFAULT 'Secundaria', -- Valor predeterminado
    Seccion VARCHAR(255),

    PrimerApellido VARCHAR(255),
    SegundoApellido VARCHAR(255),
    Celular VARCHAR(20),
    Direccion VARCHAR(255),
    Email VARCHAR(255),
    FechaNacimiento DATE,
    Observaciones VARCHAR(1000),
    NivelAcademico VARCHAR(255) DEFAULT 'Secundaria' -- Valor predeterminado
);

select*from MatriculaSecundaria

--tabla primaria


drop table MatriculaPrimaria

CREATE TABLE MatriculaPrimaria
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    PrimerNombre VARCHAR(255),
    Grado VARCHAR(255) DEFAULT 'Secundaria', -- Valor predeterminado
    Seccion VARCHAR(255),

    PrimerApellido VARCHAR(255),
    SegundoApellido VARCHAR(255),
    Celular VARCHAR(20),
    Direccion VARCHAR(255),
    Email VARCHAR(255),
    FechaNacimiento DATE,
    Observaciones VARCHAR(1000),
    NivelAcademico VARCHAR(255) DEFAULT 'Secundaria' -- Valor predeterminado
);

--consulta
select*from MatriculaPrimaria

select*from MatriculaInicial