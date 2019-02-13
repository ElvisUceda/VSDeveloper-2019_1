CREATE PROCEDURE usp_GetArtist
(@pNombre NVARCHAR(100)
)
AS
BEGIN

	SELECT ArtistId, Name
	FROM Artist
	WHERE Name like @pNombre
END
GO
drop procedure usp_InsertArtist
GO
CREATE PROCEDURE usp_InsertArtist
(
@Name NVARCHAR(120)
)
AS
BEGIN
	INSERT INTO Artist (Name)
	VALUES(@Name)

	SELECT SCOPE_IDENTITY()	

END
GO
CREATE PROCEDURE usp_InsertArtistWithOutput
(
@Name NVARCHAR(120),
@ID INT OUTPUT
)
AS
BEGIN
	INSERT INTO Artist (Name)
	VALUES(@Name)

	set @ID = SCOPE_IDENTITY()	

END
GO


CREATE PROCEDURE USP_GetGenre
(@pNombre NVARCHAR(100)
)
AS
BEGIN

	SELECT GenreId, Name
	FROM Genre
	WHERE Name like @pNombre
END
GO

CREATE PROCEDURE usp_InsertGenre
(
@Name NVARCHAR(120)
)
AS
BEGIN
	INSERT INTO Genre (Name)
	VALUES(@Name)

	SELECT SCOPE_IDENTITY()	

END
GO

SELECT TOP  * FROM Artist ORDER BY






