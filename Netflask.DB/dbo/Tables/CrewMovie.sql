CREATE TABLE [dbo].[CrewMovie] (
    [IdMovie] INT NOT NULL,
    [IdCrew]  INT NOT NULL,
    CONSTRAINT [PK_CrewMovie] PRIMARY KEY CLUSTERED ([IdMovie] ASC, [IdCrew] ASC),
    CONSTRAINT [FK_CrewMovie_ToCrew] FOREIGN KEY ([IdCrew]) REFERENCES [dbo].[Crew] ([IdCrew]),
    CONSTRAINT [FK_CrewMovie_ToMovie] FOREIGN KEY ([IdMovie]) REFERENCES [dbo].[Movie] ([IdMovie])
);

