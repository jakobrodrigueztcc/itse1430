CREATE PROCEDURE [dbo].[GetProduct]
    @Id INT
AS BEGIN
    SET NOCOUNT ON;

    SELECT Id, Name, Price, Description, IsDiscontinued
    FROM Products
    WHERE Id = @Id
END
