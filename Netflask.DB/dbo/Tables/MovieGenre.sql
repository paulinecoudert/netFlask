CREATE TABLE [dbo].[MovieGenre] (
    [IdMovie] INT NOT NULL,
    [IdGenre] INT NOT NULL,
    CONSTRAINT [PK_MovieGenre] PRIMARY KEY CLUSTERED ([IdMovie] ASC, [IdGenre] ASC),
    CONSTRAINT [FK_MovieGenre_ToGenre] FOREIGN KEY ([IdGenre]) REFERENCES [dbo].[Genre] ([IdGenre]),
    CONSTRAINT [FK_MovieGenre_ToMovie] FOREIGN KEY ([IdMovie]) REFERENCES [dbo].[Movie] ([IdMovie])
);

