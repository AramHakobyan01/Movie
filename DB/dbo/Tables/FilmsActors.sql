CREATE TABLE [dbo].[FilmsActors] (
    [FilmId]  INT NOT NULL,
    [ActorId] INT NOT NULL,
    CONSTRAINT [PK_FilmsActors] PRIMARY KEY CLUSTERED ([FilmId] ASC, [ActorId] ASC),
    FOREIGN KEY ([ActorId]) REFERENCES [dbo].[Actors] ([Id]),
    CONSTRAINT [FK__FilmsActo__FilmI__22751F6C] FOREIGN KEY ([FilmId]) REFERENCES [dbo].[Films] ([Id])
);



