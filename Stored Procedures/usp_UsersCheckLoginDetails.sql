CREATE PROCEDURE usp_UsersCheckLoginDetails
(
	@UserName NVARCHAR(50),
	@Password NVARCHAR(50)
)
AS
	BEGIN
		DECLARE @IsLoginCorrect BIT
		SET @IsLoginCorrect = 0

		IF EXISTS (SELECT '#' FROM [dbo].[Users] WHERE [UserName] = @UserName AND [Password] = @Password)
		BEGIN
			SET @IsLoginCorrect = 1
		END

		SELECT @IsLoginCorrect AS '@IsLoginCorrect'
	END