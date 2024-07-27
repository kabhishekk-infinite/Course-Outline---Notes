CREATE DATABASE test2;
GO

USE test2;
GO

--ex 2. create a function that returns the total no of male employees

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    Name NVARCHAR(100),
    Gender CHAR(1)
);
GO

INSERT INTO Employees (EmployeeID, Name, Gender) VALUES (1, 'Abhishek', 'M');
INSERT INTO Employees (EmployeeID, Name, Gender) VALUES (2, 'Ankit', 'M');
INSERT INTO Employees (EmployeeID, Name, Gender) VALUES (3, 'Om', 'M');
INSERT INTO Employees (EmployeeID, Name, Gender) VALUES (4, 'Aisha', 'F');
GO

CREATE FUNCTION dbo.GetTotalMaleEmployees()
RETURNS INT
AS
BEGIN
    DECLARE @TotalMaleEmployees INT;

    SELECT @TotalMaleEmployees = COUNT(*)
    FROM Employees
    WHERE Gender = 'M';

    RETURN @TotalMaleEmployees;
END;
GO

SELECT dbo.GetTotalMaleEmployees() AS TotalMaleEmployees;
GO


--ex 3. Write a function to add 2 numbers and return the value

CREATE FUNCTION dbo.AddTwoNumbers (@Number1 INT, @Number2 INT)
RETURNS INT
AS
BEGIN
    DECLARE @Result INT;

    SET @Result = @Number1 + @Number2;

    RETURN @Result;
END;
GO

SELECT dbo.AddTwoNumbers(5, 10) AS Result;
GO


--ex 4. write a function to calculate the area of rectangle

CREATE FUNCTION dbo.CalculateRectangleArea (@Length FLOAT, @Width FLOAT)
RETURNS FLOAT
AS
BEGIN
    DECLARE @Area FLOAT;

    SET @Area = @Length * @Width;

    RETURN @Area;
END;
GO

SELECT dbo.CalculateRectangleArea(10, 5) AS Area;
GO


--multistatement tabled valued

create or alter function fn_GetEmployeesbyGender(@gender varchar(8))

returns

@EmpBygender table(

Empid int, EmployeeName varchar(40),

Gender varchar(7))

as

begin

--bulk insertion

insert into @EmpBygender

select Empid,Empname,gender from tblemployees 

where Gender= @gender

--handling exception situation

if @@ROWCOUNT = 0

begin

  insert into @EmpBygender

  values(0,'No Emp found with the given gender',null)

  end

return

end
 
--to execute the above function

select * from fn_GetEmployeesbyGender('male')
 

