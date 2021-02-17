CREATE TABLE [dbo].[Critics] (
    [IdMovie]         INT        NOT NULL,
    [IdCriticsAuthor] INT        NOT NULL,
    [Score]           FLOAT (53) NOT NULL,
    PRIMARY KEY CLUSTERED ([IdCriticsAuthor] ASC, [IdMovie] ASC),
    CONSTRAINT [FK_Critics_ToCriticsAuthor] FOREIGN KEY ([IdCriticsAuthor]) REFERENCES [dbo].[CriticsAuthor] ([IdCriticsAuthor]),
    CONSTRAINT [FK_Critics_ToMovie] FOREIGN KEY ([IdMovie]) REFERENCES [dbo].[Movie] ([IdMovie])
);

