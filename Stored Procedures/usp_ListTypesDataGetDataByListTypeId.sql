CREATE PROCEDURE usp_ListTypesDataGetDataByListTypeId
(
	@ListTypeId INT
)
AS
	BEGIN
		SELECT [ListTypedataId] AS 'Id'
			  ,[Description]
		FROM [dbo].[ListTypeData]
		WHERE [ListTypeId] = @ListTypeId
	END