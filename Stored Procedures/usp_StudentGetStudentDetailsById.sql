CREATE PROCEDURE usp_StudentGetStudentDetailsById
(
	@StudentId INT
)
AS
	BEGIN
		SELECT [StudentId]
		  ,[StudentName]
		  ,[FatherName]
		  ,[PhoneNumber]
		  ,[CityId]
		  ,[EmailAddress]
		  ,[DepartmentId]
		  ,[AddressLine]
	  FROM [dbo].[Student]
	  WHERE [StudentId] = @StudentId
	END

GO


