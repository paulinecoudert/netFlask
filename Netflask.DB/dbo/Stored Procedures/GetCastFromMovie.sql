/****** Script de la commande SelectTopNRows à partir de SSMS  ******/
CREATE PROCEDURE [dbo].[GetCastFromMovie]
@idMovie int
AS
SELECT        Cast.*
FROM            Cast INNER JOIN
                         MovieCast ON Cast.IdCast = MovieCast.IdCast
						 WHERE MovieCast.IdMovie= @idMovie
