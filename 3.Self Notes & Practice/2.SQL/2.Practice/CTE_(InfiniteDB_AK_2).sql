-----------------------------------------		SQL 4	---------------------------------------------------

--Common Table Expression (CTE) : Allows us to define a named temporary result set that is available within the execution scope
--A Common Table Expression (CTE) in SQL allows you to create a temporary result set that you can reference within a SELECT, INSERT, UPDATE, or DELETE statement.
--CTEs are particularly useful for breaking down complex queries, improving readability, and making recursive queries easier to write.

--Let's consider a database with a table named " Employees " which contains the following columns:--
--EmployeeID,
--FirstName, 
--LastName, 
--ManagerID, 
--Salary.

-- DB Name..
USE InfiniteDB_AK;

--Table.. " Employees "
CREATE TABLE Employees
	(
		EmployeeID INT PRIMARY KEY,
		FirstName  VARCHAR(20),
		LastName   VARCHAR(20),
		ManagerID  INT,
		Salary	   INT
	);

INSERT INTO Employees
VALUES  (101, 'Abhishek', 'Kumar', 2001, 50000),
		(102, 'Om', 'Verma', 3010, 40000),
		(103, 'Rishab', 'Raj', 1002, 35000),
		(104, 'Zoya', 'Khan', 2001, 50000),
		(105, 'Ankita', 'Gupta', 3050, 25000),
		(106, 'Shivani', 'Malhotra', 4080, 30000),
		(107, 'Sahil', 'Roy', 3010, 40000),
		(108, 'Ankit', 'Kumar', 1070, 40000),
		(109, 'Sakina', 'Bhaat', 2005, 35000),
		(110, 'Bishnu', 'Tharu', 4080, 30000);

SELECT * FROM Employees;

-- Example 1: Simple CTE (Type 1).
-- Suppose you want to retrieve a list of employees with their full names (combination of FirstName and LastName).

--Define the CTE

WITH EmpFullName AS
	(
		SELECT 
			EmployeeID,
			FirstName + ' ' + LastName AS FullName,
			ManagerID,
			Salary AS MonthlySalary,
			(Salary * 12) AS AnnualSalary
		FROM Employees
	)
SELECT *										--Use the CTE in the main Query.
FROM EmpFullName;

--Example 2: Recursive CTE
--A recursive CTE is useful for hierarchical data, such as finding all employees in the organizational hierarchy starting from a specific manager.

WITH Spf_Manager AS
	 (
		SELECT 
			EmployeeID,
			FirstName + ' ' + LastName AS FullName,
			ManagerID,
			Salary AS MonthlySalary,
			(Salary * 12) AS AnnualSalary,
			1 AS LEVEL 
		FROM Employees
		WHERE ManagerID = '2001'

		UNION ALL

		-- Recursive member: Select employees under the current level's employees
		SELECT 
			E.EmployeeID,
			E.FirstName + ' ' + E.LastName AS FullName,
			E.ManagerID,
			E.Salary AS MonthlySalary,
			(E.Salary * 12) AS AnnualSalary,
		    SM.LEVEL + 1 AS LEVEL
		FROM Employees E
		INNER JOIN Spf_Manager SM 
		ON E.ManagerID = SM.EmployeeID
	 )
SELECT * 
FROM Spf_Manager
ORDER BY LEVEL, FullName

SELECT * FROM tblDepartment;
SELECT * FROM tblemployees;

-- Q.1> Single CTE
WITH firstcte(Empname, AnnualSalary, Department) AS
		(
			SELECT Empname, (Salary*12), tblDepartment.DeptName
			FROM tblemployees
			JOIN 
			tblDepartment ON tblemployees.DeptNo = tblDepartment.DeptNo
		)

--Main Query - 1
	--SELECT * FROM firstcte
	--WHERE AnnualSalary > 75000;

-- Query - 2
SELECT Department, AVG(AnnualSalary) AS 'Dept Average'
FROM firstcte
group by Department
Having AVG(AnnualSalary) > 78000;




























