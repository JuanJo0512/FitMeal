ALTER DATABASE FitMeal SET SINGLE_USER WITH ROLLBACK IMMEDIATE; 
-- Eliminacion de la talba
DROP DATABASE FitMeal;

Create database FitMeal

USE FitMeal

-- Creación de la tabla USUARIOS
CREATE TABLE USUARIOS (
    Cedula VARCHAR(20) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    Edad INT,
    Sexo CHAR(1),
    Altura DECIMAL(5, 2), -- en cm
    Peso DECIMAL(5, 2),   -- en kg
    Meta VARCHAR(100),
    email VARCHAR(100) UNIQUE NOT NULL,
    Contrasena VARCHAR(255) NOT NULL
);

-- Creación de la tabla ALIMENTO
CREATE TABLE ALIMENTO (
    AlimentoID INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Categoria VARCHAR(50),
    Calorias DECIMAL(8, 2),
    Proteinas DECIMAL(8, 2),
    Carbohidratos DECIMAL(8, 2),
    Grasas DECIMAL(8, 2)
);

-- Creación de la tabla RECETA
CREATE TABLE RECETA (
    RecetaID INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(MAX),
    Categoria VARCHAR(20) CHECK (Categoria IN ('Desayuno', 'Almuerzo', 'Cena', 'Snack')) not null,
	TipoDieta Varchar(30) not null,
	TipoDieta2 varchar(30),
    TotalCalorias DECIMAL(8, 2) not null,
    TotalProteinas DECIMAL(8, 2) not null,
    TotalCarbohidratos DECIMAL(8, 2) not null,
);

-- Creación de la tabla INGREDIENTES_RECETA
CREATE TABLE INGREDIENTES_RECETA (
    IngredienteID INT PRIMARY KEY IDENTITY(1,1),
    RecetaID INT,
    AlimentoID INT,
    Cantidad VARCHAR(50), -- Se guarda como texto para flexibilidad (ej. "100 gramos", "50 ml")
    FOREIGN KEY (RecetaID) REFERENCES RECETA(RecetaID),
    FOREIGN KEY (AlimentoID) REFERENCES ALIMENTO(AlimentoID)
);

-- Creación de la tabla PLANDIETA
CREATE TABLE PLANDIETA (
    PlanID INT PRIMARY KEY IDENTITY(1,1),
    Cedula VARCHAR(20),
    FechaInicio DATE,
    FechaFin DATE,
    ObjetivoCalorias DECIMAL(8, 2),
    Estado VARCHAR(20) CHECK (Estado IN ('Activo', 'Ajustado', 'Finalizado')),
    FOREIGN KEY (Cedula) REFERENCES USUARIOS(Cedula)
);

-- Creación de la tabla COMIDA_PLANIFICADA
CREATE TABLE COMIDA_PLANIFICADA (
    ComidaID INT PRIMARY KEY IDENTITY(1,1),
    PlanID INT,
    RecetaID INT,
    Fecha DATE,
    TipoComida VARCHAR(20) CHECK (TipoComida IN ('Desayuno', 'Almuerzo', 'Cena', 'Snack')),
    FOREIGN KEY (PlanID) REFERENCES PLANDIETA(PlanID),
    FOREIGN KEY (RecetaID) REFERENCES RECETA(RecetaID)
);

-- Creación de la tabla PROGRESO
CREATE TABLE PROGRESO (
    ProgresoID INT PRIMARY KEY IDENTITY(1,1),
    Cedula VARCHAR(20),
    Fecha DATE,
    FOREIGN KEY (Cedula) REFERENCES USUARIOS(Cedula)
);

-- Creación de la tabla REGISTRO_ACTIVIDAD
CREATE TABLE REGISTRO_ACTIVIDAD (
    ActividadID INT PRIMARY KEY IDENTITY(1,1),
    ProgresoID INT,
    TipoEjercicio VARCHAR(100),
    Fecha DATE,
    CaloriasQuemadas DECIMAL(8, 2),
    TiempoEjercicio INT, -- en minutos
    FOREIGN KEY (ProgresoID) REFERENCES PROGRESO(ProgresoID)
);

-- Creación de la tabla REGISTRO_COMIDAS
CREATE TABLE REGISTRO_COMIDAS (
    ComidasID INT PRIMARY KEY IDENTITY(1,1),
    ProgresoID INT,
    RecetaID INT,
    Fecha DATE,
    NombreComida VARCHAR(100),
    Categoria VARCHAR(50),
    CantidadCalorias DECIMAL(8, 2),
    FOREIGN KEY (ProgresoID) REFERENCES PROGRESO(ProgresoID),
    FOREIGN KEY (RecetaID) REFERENCES RECETA(RecetaID)
);

-- Creación de la tabla PREF_USUARIO para preferencias
CREATE TABLE PREF_USUARIO (
    Pref_UsuarioID INT PRIMARY KEY IDENTITY(1,1),
    AlimentoID INT,
    Cedula VARCHAR(20),
    FOREIGN KEY (AlimentoID) REFERENCES ALIMENTO(AlimentoID),
    FOREIGN KEY (Cedula) REFERENCES USUARIOS(Cedula)
);

-- Creación de la tabla ALERGIA (catálogo de alergias)
CREATE TABLE ALERGIA (
    AlergiaID INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(MAX)
);

-- Creación de la tabla ALERG_ALIMENTO (asociación entre alergias y alimentos)
CREATE TABLE ALERG_ALIMENTO (
    Alerg_AlimentoID INT PRIMARY KEY IDENTITY(1,1),
    AlergiaID INT,
    AlimentoID INT,
    FOREIGN KEY (AlergiaID) REFERENCES ALERGIA(AlergiaID),
    FOREIGN KEY (AlimentoID) REFERENCES ALIMENTO(AlimentoID)
);

-- Creación de la tabla ALERG_USUARIO (asociación entre usuarios y alergias)
CREATE TABLE ALERG_USUARIO (
    Alerg_usuarioID INT PRIMARY KEY IDENTITY(1,1),
    AlergiaID INT,
    Cedula VARCHAR(20),
    FOREIGN KEY (AlergiaID) REFERENCES ALERGIA(AlergiaID),
    FOREIGN KEY (Cedula) REFERENCES USUARIOS(Cedula)
);

--Creacion de la tabla FeedBack
CREATE TABLE FEEDBACK(
	FeedBackID INT PRIMARY KEY IDENTITY(1,1),
	Cedula VARCHAR(20),
	Destacado VARCHAR(250),
	Mejoras VARCHAR(250),
	FOREIGN KEY (Cedula) REFERENCES USUARIOS(Cedula)
);

ALTER TABLE FEEDBACK
ADD Puntuacion INT CHECK (Puntuacion >= 1 AND Puntuacion <= 5);
