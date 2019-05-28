CREATE PROCEDURE usp_StudentsGenerateNewStudentId
AS
	BEGIN
		DECLARE @StudentId INT
		SELECT @StudentId = ISNULL(MAX(StudentId), 0) 
		FROM [dbo].[Student]
		SET @StudentId = @StudentId + 1
		SELECT @StudentId
	END