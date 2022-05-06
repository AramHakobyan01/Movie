CREATE TABLE [dbo].[Films] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NOT NULL,
    [DateRelease] INT            NOT NULL,
    [Rating]      FLOAT (53)     NOT NULL,
    [About]       NVARCHAR (MAX) NULL,
    CONSTRAINT [PK__Films__3214EC0751FA21EF] PRIMARY KEY CLUSTERED ([Id] ASC)
);



