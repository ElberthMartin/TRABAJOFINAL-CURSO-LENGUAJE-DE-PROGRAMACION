CREATE TABLE MatriculaPrimaria (
    Id INT PRIMARY KEY IDENTITY(1,1),
    PrimerNombre VARCHAR(255) NOT NULL,
    SegundoNombre VARCHAR(255),
    PrimerApellido VARCHAR(255) NOT NULL,
    SegundoApellido VARCHAR(255),
    Celular VARCHAR(15),
    Direccion VARCHAR(255),
    Email VARCHAR(255),
    FechaNacimiento DATE,
    Observaciones TEXT
);
