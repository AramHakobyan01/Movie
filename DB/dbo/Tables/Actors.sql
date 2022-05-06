CREATE TABLE [dbo].[Actors] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (50) NOT NULL,
    [Surname] NVARCHAR (50) NOT NULL,
    [Rating]  FLOAT (53)    NOT NULL,
    [About]   NVARCHAR (MAX) NULL
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

