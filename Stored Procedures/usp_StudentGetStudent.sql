CREATE PROCEDURE usp_StudentGetStudent
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

	END

GO


