CREATE TABLE [dbo].[PokemonxEquipos]
(
	[IdPokemon] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [idEquipo] UNIQUEIDENTIFIER NOT NULL,
	    CONSTRAINT FK_PKEqui_Pokemon FOREIGN KEY (idPokemon)
        REFERENCES [dbo].[Pokemon] (id),
		CONSTRAINT FK_PKEqui_Equipo FOREIGN KEY (idEquipo)
        REFERENCES [dbo].[Equipos] (idEquipo)
)
