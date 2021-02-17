CREATE TABLE [dbo].[MovieCast] (
    [IdCast]  INT NOT NULL,
    [idMovie] INT NOT NULL,
    CONSTRAINT [PK_MovieCast] PRIMARY KEY CLUSTERED ([IdCast] ASC, [idMovie] ASC),
    CONSTRAINT [FK_MovieCast_ToCast] FOREIGN KEY ([IdCast]) REFERENCES [dbo].[Cast] ([IdCast]),
    CONSTRAINT [FK_MovieCast_ToMovie] FOREIGN KEY ([idMovie]) REFERENCES [dbo].[Movie] ([IdMovie])
);

