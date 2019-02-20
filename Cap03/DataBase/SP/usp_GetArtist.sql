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

CREATE PROCEDURE usp_UpdateArtist
(
@Name NVARCHAR(120),
@ID INT
)
AS
BEGIN
	UPDATE Artist
	SET [Name] = @Name
	WHERE ArtistId = @ID
END
GO

CREATE PROCEDURE usp_DeleteArtist
(
@Name NVARCHAR
)
AS
BEGIN
	DELETE
	FROM Artist 
	WHERE Name =@Name
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

CREATE PROCEDURE usp_UpdateGenre
(
@Name NVARCHAR(120),
@GenreId INT 
)
AS
BEGIN
	UPDATE Genre
	SET Name = @Name
	where GenreId = @GenreId
	
END
GO

CREATE PROCEDURE usp_DeleteGenre
@Name NVARCHAR
AS
BEGIN
	DELETE
	FROM Genre
	WHERE Name = @Name
END
GO
SELECT TOP 10 * FROM Artist WITH (NOLOCK)
ORDER BY ArtistId DESC
GO
SELECT TOP 10 * FROM Artist
ORDER BY ArtistId DESC
GO

CREATE PROCEDURE usp_GetAlbum
(@pTitle NVARCHAR(160)
)
AS
BEGIN

	SELECT AlbumId, Title
	FROM Album
	WHERE Title like @pTitle
END
GO

CREATE PROCEDURE usp_InsertAlbum
(
@AlbumId INT,
@Title NVARCHAR(160),
@ArtistId INT
)
AS
BEGIN
	INSERT INTO Album (AlbumId, Title, ArtistId)
				VALUES(@AlbumId, @Title, @ArtistId)
	SELECT SCOPE_IDENTITY()	
END
GO


