
CREATE DATABASE BibliotecaDb;
GO

USE BibliotecaDb;
GO

CREATE TABLE Autor (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    NombreCompleto VARCHAR(150) NOT NULL,
    FechaNacimiento VARCHAR(10) NOT NULL,
    CiudadProcedencia VARCHAR(100) NULL,
    CorreoElectronico VARCHAR(150) NOT NULL UNIQUE
);

CREATE TABLE Libro (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Titulo VARCHAR(150) NOT NULL,
    Año VARCHAR(4) NOT NULL,
    Genero VARCHAR(50) NULL,
    NumeroPaginas INT NOT NULL,
    AutorId INT NOT NULL,
    CONSTRAINT FK_Libro_Autor
        FOREIGN KEY (AutorId) REFERENCES Autor(Id)
);
