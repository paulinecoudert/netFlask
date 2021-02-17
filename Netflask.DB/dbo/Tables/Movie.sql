CREATE TABLE [dbo].[Movie] (
    [IdMovie]          INT            NOT NULL,
    [Title]            NVARCHAR (250) NOT NULL,
    [Duration]         INT            NOT NULL,
    [Picture]          NVARCHAR (250) NOT NULL,
    [Trailer]          NVARCHAR (250) NOT NULL,
    [ReleaseDate]      DATE           NULL,
    [Summary]          NVARCHAR (MAX) NOT NULL,
    [ShortDescription] NVARCHAR (150) NOT NULL,
    PRIMARY KEY CLUSTERED ([IdMovie] ASC)
);

