CREATE TABLE [dbo].[Equipos]
(
    [IdEquipo]     UNIQUEIDENTIFIER NOT NULL,
    [IdEntrenador] UNIQUEIDENTIFIER NOT NULL,
    [Nombre]       VARCHAR (MAX)    NOT NULL,
    CONSTRAINT [PK__Equipos__D8052408E97114AD] PRIMARY KEY CLUSTERED ([IdEquipo] ASC),
    CONSTRAINT [FK_Equipos_Entrenadores] FOREIGN KEY ([IdEntrenador]) REFERENCES [dbo].[Entrenadores] ([Id]) ON UPDATE CASCADE
)
