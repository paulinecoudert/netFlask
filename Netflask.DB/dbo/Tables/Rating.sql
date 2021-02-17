CREATE TABLE [dbo].[Rating] (
    [IdMovie]    INT        NOT NULL,
    [IdUser]     INT        NOT NULL,
    [Score]      FLOAT (53) NOT NULL,
    [DateRating] DATE       NOT NULL,
    CONSTRAINT [PK_Rating] PRIMARY KEY CLUSTERED ([IdUser] ASC, [IdMovie] ASC),
    CONSTRAINT [FK_Rating_ToMovie] FOREIGN KEY ([IdMovie]) REFERENCES [dbo].[Movie] ([IdMovie]),
    CONSTRAINT [FK_Rating_ToUser] FOREIGN KEY ([IdUser]) REFERENCES [dbo].[User] ([IdUser])
);

