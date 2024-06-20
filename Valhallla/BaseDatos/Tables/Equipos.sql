CREATE TABLE [dbo].[Equipos]
(
	[IdEquipo] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [idEntrenador] UNIQUEIDENTIFIER NOT NULL, 
    [Nombre] VARCHAR(MAX) NOT NULL,
    CONSTRAINT FK_Equipos_Entrenadores FOREIGN KEY (idEntrenador) REFERENCES [dbo].[Entrenadores] (id)
)
