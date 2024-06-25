CREATE TABLE [dbo].[PokemonxEquipos]
(
	[IdPokemon] UNIQUEIDENTIFIER NOT NULL, 
    [idEquipo] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_PokemonxEquipos] PRIMARY KEY CLUSTERED ([IdPokemon] ASC, [IdEquipo] ASC),
    CONSTRAINT [FK_PokemonxEquipos_Equipos1] FOREIGN KEY ([IdEquipo]) REFERENCES [dbo].[Equipos] ([IdEquipo]),
    CONSTRAINT [FK_PokemonxEquipos_Pokemon1] FOREIGN KEY ([IdPokemon]) REFERENCES [dbo].[Pokemon] ([Id])
)
