/****** Script de la commande SelectTopNRows à partir de SSMS  ******/
CREATE PROCEDURE [dbo].[GetGenreFromMovie]
@idMovie int
AS
SELECT        Genre.Label, MovieGenre.IdMovie, Genre.IdGenre
FROM            Genre INNER JOIN
                         MovieGenre ON Genre.IdGenre = MovieGenre.IdGenre
						 WHERE MovieGenre.IdMovie= @idMovie
