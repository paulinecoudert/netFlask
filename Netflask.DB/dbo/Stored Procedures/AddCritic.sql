
-- =============================================
-- Author:		Mike
-- Create date: 29/01/2021
-- Description:	Procédure permettant d'ajouter une critique
-- =============================================
CREATE PROCEDURE AddCritic
@IdMovie int,
@IdCriticsAuthor int,
@score float
AS
BEGIN
	 INSERT INTO Critics VALUES(@IdMovie, @IdCriticsAuthor, @score)
END