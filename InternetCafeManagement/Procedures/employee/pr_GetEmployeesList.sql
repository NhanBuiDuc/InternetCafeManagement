CREATE PROCEDURE pr_GetEmployeesList @position nvarchar(50)
AS
SELECT * FROM employee WHERE position = @position