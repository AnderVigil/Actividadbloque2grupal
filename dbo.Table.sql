CREATE TABLE Peliculas (
    Id INT PRIMARY KEY IDENTITY(1,1), -- Clave primaria, auto-incremental
    Titulo NVARCHAR(100) NOT NULL,    -- Título de la película
    Autor NVARCHAR(100) NOT NULL,     -- Autor o director
    Sinopsis NVARCHAR(MAX) NULL,      -- Sinopsis de la película
    Duracion INT NOT NULL,            -- Duración en minutos
    Clasificacion NVARCHAR(50) NOT NULL -- Clasificación de la película
);