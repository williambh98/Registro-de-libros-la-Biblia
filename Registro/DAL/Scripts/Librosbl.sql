---CREATE DATABASE LibrosDb

GO

USE LibrosDb

GO
CREATE TABLE Libros
(
LibroId int primary key identity,
Descripcion varchar (30) NOT NULL,
Siglas varchar (15),
Tipolb varchar (max)

);

---select * from  Libros
