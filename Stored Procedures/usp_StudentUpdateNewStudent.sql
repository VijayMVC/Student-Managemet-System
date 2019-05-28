CREATE PROCEDURE usp_StudentUpdateNewStudent
(
	@StudentId INT
   ,@StudentName NVARCHAR(50)			
   ,@FatherName NVARCHAR(50)
   ,@PhoneNumber NVARCHAR(50)
   ,@CityId INT
   ,@EmailAddress NVARCHAR(50)
   ,@DepartmentId INT
   ,@AddressLine NVARCHAR(50)
)
AS
	BEGIN
		UPDATE [dbo].[Student]
		   SET [StudentId] = @StudentId
			  ,[StudentName] = @StudentName
			  ,[FatherName] = @FatherName
			  ,[PhoneNumber] = @PhoneNumber
			  ,[CityId] = @CityId
			  ,[EmailAddress] = @EmailAddress
			  ,[DepartmentId] = @DepartmentId
			  ,[AddressLine] = @AddressLine
		 WHERE [StudentId] = @StudentId
	END

GO


