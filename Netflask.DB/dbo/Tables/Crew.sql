CREATE TABLE [dbo].[Crew] (
    [IdCrew]    INT            NOT NULL,
    [FirstName] NVARCHAR (MAX) NOT NULL,
    [LastName]  NVARCHAR (50)  NOT NULL,
    [Job]       NVARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([IdCrew] ASC)
);

