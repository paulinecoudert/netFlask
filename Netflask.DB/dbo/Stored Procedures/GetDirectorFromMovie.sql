/****** Script de la commande SelectTopNRows à partir de SSMS  ******/
CREATE PROCEDURE [dbo].[GetDirectorFromMovie]
@idMovie int
AS
SELECT        Crew.IdCrew, Crew.FirstName, Crew.LastName, Crew.Job,
 CrewMovie.IdMovie
FROM            Crew INNER JOIN
                         CrewMovie ON Crew.IdCrew = CrewMovie.IdCrew
WHERE        (Crew.Job = 'Director') and CrewMovie.IdMovie=@idMovie
