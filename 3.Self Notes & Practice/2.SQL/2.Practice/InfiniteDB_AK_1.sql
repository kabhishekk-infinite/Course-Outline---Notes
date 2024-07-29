-----------------------------------------		SQL 1	---------------------------------------------------

-- New DB
CREATE DATABASE InfiniteDB_AK

-- use DB
USE InfiniteDB_AK
GO

-- create table - tblDepartment
CREATE TABLE tblDepartment(
		DeptNo INT PRIMARY KEY,				 --column level constraint
		DeptName VARCHAR(15) NOT NULL,
		Budget FLOAT
	);
	
-- view/retrieve data from table
SELECT * FROM tblDepartment;

-- create table - tblemployees
CREATE TABLE tblemployees
	(
		Empid INT PRIMARY KEY,				 
		Empname VARCHAR(40) NOT NULL,
		Gender CHAR(7),
		Salary FLOAT,
		DeptNo INT REFERENCES tblDepartment(DeptNo)			-- foreign key 
	);

-- Alter Table -> Add Column without DATA
ALTER TABLE tblemployees
ADD Phoneno VARCHAR(10) UNIQUE;		-- constraint while adding a column after table creation

-- Check both tables
SELECT * FROM tblDepartment;
SELECT * FROM tblemployees;

-- Various types to enter data into table
-- Now Add data into Table 'tblDepartment'

-- 1. Insert single row at a time.
INSERT INTO tblDepartment
VALUES	(1, 'IT', 2000000);

-- 2. Insert single row at a time.
INSERT INTO tblDepartment(DeptNo, DeptName, Budget)
VALUES	(2, 'HR', NULL);

-- 3. Insert multiple row at a time or with single Insert.
INSERT INTO tblDepartment
VALUES	(5, 'Testing', 1000000),
		(3, 'Admin', 3000000),
		(4, 'Operations', NULL);

-- 4. Insert data into table with only selected column
INSERT INTO tblDepartment(DeptNo, DeptName)
VALUES	(6, 'Accouts');

-- check all data in table
SELECT * FROM tblDepartment;

-- Alter Table -> Add Column witH DATA
ALTER TABLE tblDepartment
ADD Loc VARCHAR(10);			-- with all NULL values.

-- update the column Loc
UPDATE tblDepartment
SET Loc = 'Pune'
WHERE DeptNo = 6;

-- update the null column in Loc
UPDATE tblDepartment
SET Loc = 
    CASE 
        WHEN DeptNo = 1 THEN 'aa'
        WHEN DeptNo = 2 THEN 'bb'
        WHEN DeptNo = 3 THEN 'cc'
        WHEN DeptNo = 4 THEN 'dd'
        WHEN DeptNo = 5 THEN 'ee'
    END
WHERE DeptNo IN (1, 2, 3, 4, 5);					-- clause ensures that only the rows with DeptNo 1, 2, 3, 4, and 5 are updated.

--adding a constraint to a column of a table
ALTER TABLE tblDepartment
ADD CONSTRAINT con_uniq_loc UNIQUE (Loc);

-- Check both tables
SELECT * FROM tblDepartment;
SELECT * FROM tblemployees;

--let us add a check constraint on salary column of tblemployee table
ALTER TABLE tblemployees
ADD CONSTRAINT chksal CHECK(Salary >= 6000);

-- Now Add data into Table 'tblemployees'
INSERT INTO tblemployees
VALUES	(103, 'Anitha Gayathri', 'Female', 6100, 2, '2222211'),
		(102, 'Adikeshava',      'Male',   6200, 1, '3333221'),
		(105, 'Bindu',           'Female', 6200, 2, '432125' ),
		(101, 'Abishek Lomte',   'Male',   6000, 3, '2345677');

--check
SELECT * FROM tblemployees;

--adding a city column to the employees table with a default constraint
ALTER TABLE tblemployees
ADD City VARCHAR(30);

-- add default city name
ALTER TABLE tblemployees
ADD CONSTRAINT city_def DEFAULT 'Bangalore' for City;

-- Insert new row with city as default value.
INSERT INTO tblemployees(Empid, Empname, Salary, DeptNo, Phoneno)
VALUES	(106,'Aman Ullah', 6300,4,73522380);

-- Insert new row with city not as default value.
INSERT INTO tblemployees(Empid, Empname, Salary, DeptNo, Phoneno, City) 
VALUES	(107,'Ayesha', 6300,4,768522380,'Hyderabad');

--Foreign key constraints with alter
ALTER TABLE tblemployees
ADD FOREIGN KEY(DeptNo) REFERENCES tblDepartment(DeptNo);

-- Check both tables
SELECT * FROM tblDepartment;
SELECT * FROM tblemployees;


--let us try to have all the constraints during table creation at column level

CREATE TABLE SampleTable (
	SampleID	  INT PRIMARY KEY, 
	SampleName    VARCHAR(20) NOT NULL,
	SampleCity    VARCHAR(30) DEFAULT 'XXX',
	SampleGrade   INT CHECK  (SampleGrade >10 and SampleGrade <50),
	SampleNumber  INT UNIQUE,
	SampleCountry VARCHAR(20) NULL,
	SampleKey	  INT REFERENCES tblDepartment(DeptNo)
	);

	SELECT * FROM SampleTable

-- Table level constraint
CREATE TABLE SampleT (
	sampleid	  int,
	samplename    varchar(20),
	samplegrade   int,
	samplenumber  int,
	samplekey	  int,
	samplecity    varchar(50) DEFAULT 'XXX',
	PRIMARY KEY(sampleid),				--Table Level constraints
	CONSTRAINT chk_grade CHECK(samplegrade >10 and samplegrade<50),
	CONSTRAINT fk_sample FOREIGN KEY(samplekey) REFERENCES tblDepartment(DeptNo),
	CONSTRAINT u_cons UNIQUE(samplenumber)
	);

	SELECT * FROM SampleT

-- All
SELECT * FROM tblDepartment;
SELECT * FROM tblemployees;
SELECT * FROM SampleTable;
SELECT * FROM SampleT;
EXEC sp_helpconstraint 'tblemployees';

-- Questions :--


--- Q.1.>  Drop a user named constraint on tblemployees ?
			ALTER TABLE tblemployees
			DROP CONSTRAINT city_def;
--- Q.2.>  Droppping a system generated constraint ?
			alter table tblemployees
		    drop constraint [UQ__tblemplo__F2111EDAC14E40D4];
--- Q.3.>  Dropping a column from a table after dropping the constaint ?
			ALTER TABLE tblemployees
			DROP CONSTRAINT city_def;

			ALTER TABLE tblemployees
			DROP COLUMN City;

--- Q.4.>  To view the table with its constraints and all descriptions ?
			sp_help 'tblemployees';

--- Q.5.>  Disable a check constraint
			ALTER TABLE tblemployees
			NOCHECK CONSTRAINT chksal;

--- Q.6.>  Enable a check constraint
			-- Verify the constraint status
			SELECT 
			  name AS constraint_name,
			  type_desc,
			  is_disabled
			FROM
			  sys.check_constraints
			WHERE
			  parent_object_id = OBJECT_ID('tblemployees');

			  -- Now enable it
			  ALTER TABLE tblemployees
			  WITH CHECK CHECK CONSTRAINT chksal;

--- Q.7.>  Select clause ?
			-- It means retrive data from 1 or more table. Also specific data can be retrived
			SELECT * FROM tblemployees 
			SELECT Empname, Salary FROM tblemployees
			select * from tblemployees where DeptNo = 1;

--- Q.8.>  Top records ?
			SELECT TOP 3 * FROM tblemployees;

--- Q.9.>  Top percentage of records ?
			SELECT TOP 30 PERCENT Empname FROM tblemployees;

--- Q.10.> Alias names in select ?
			SELECT Empname AS EmployeeName FROM tblemployees
			SELECT Empname AS 'Employee Name' FROM tblemployees;

--- Q.11.> Computational columns/ arithmetic operators ?
			SELECT
				Empname AS 'Employee Name',
				Salary  AS 'Monthly Salary',
				(Salary * 12) AS 'Annual Salary',
				(Salary / 30) AS 'Daily Salary'
			FROM tblemployees;

--- Q.12.> Relational operators and logical operators ?
			SELECT * FROM tblemployees WHERE Salary > 6000;
				
			SELECT Empname, DeptNo, (Salary + 1000) AS Incentive 
			FROM tblemployees 
			WHERE DeptNo > 1;

			SELECT * FROM tblemployees WHERE Salary >=6100 AND Salary <=6500;
			SELECT * FROM tblemployees WHERE Salary Between 6100 And 6500;
			SELECT * FROM tblemployees WHERE Salary Not Between  6100 And 6500;

--- Q.13.> Null values ?
			SELECT * FROM tblemployees WHERE DeptNo Is NULL;
			SELECT * FROM tblemployees WHERE DeptNo Is NOT NULL;

--- Q.14.> In operator ?
			SELECT Empname, DeptNo, Salary FROM tblemployees WHERE DeptNo IN (1, 3);
			SELECT Empname, DeptNo, Salary  FROM tblemployees WHERE DeptNo NOT IN (1, 3);

--- Q.15.>  Wildcard Characters with LIKE Keyword ?
			SELECT * FROM tblemployees WHERE Empname LIKE 'A%';
			SELECT * FROM tblemployees WHERE Empname LIKE 'A_i%';
			SELECT * FROM tblemployees WHERE Empname LIKE '%a';
			SELECT * FROM tblemployees WHERE Empname LIKE 'A[bdny]%';
			SELECT * FROM tblemployees WHERE Empname LIKE 'A[^bdny]%';

--- Q.16.> Select with aggregate functions ?
			SELECT MAX(Salary) FROM tblemployees;
			SELECT AVG(Salary), MIN(Salary) FROM tblemployees;

			select count(empid) from tblemployees;
			select count(deptno) from tblemployees; -- count includes duplicates

			select count(distinct(deptno)) from tblemployees;  -- distinct removes duplicates

--- Q.17.> Deletion ?
			-- add new row
			INSERT INTO tblemployees
			VALUES (200,'ABHISHEK KUMAR', 'Male', 10000, 1, '1234567890');

			--view table with new row
			SELECT * FROM tblemployees;

			-- Now delete new row
			DELETE FROM tblemployees WHERE Empid = 200;

--- Q.18.> Order by clause to sort the data being displayed ?
			SELECT Empid, Salary FROM tblemployees ORDER BY Empname;
			SELECT Empid, Salary, Empname AS EmployeeName FROM tblemployees ORDER BY EmployeeName;
			
--- Q.19.> To test Multiple sorts with asc and desc ?
			-- add 2 new row.
			INSERT INTO tblemployees
			VALUES (200,'ABHISHEK KUMAR', 'Male', 10000, 1, '1234567890'),
				   (300,'Banurekha','Female',6350,3,'666666');
			
			--view table with new row
			SELECT * FROM tblemployees;

			--Update salary of EMpid
			UPDATE tblemployees SET Salary = 6400 WHERE Empid = 200;

			--Sort 
			SELECT Empid, Salary, Empname FROM tblemployees ORDER BY Salary DESC, empname;

			--Now delete 1 Row
			DELETE FROM tblemployees WHERE Empid = 200;

			
-----------------------------------------		SQL 2	---------------------------------------------------
--The DQL works in the following order
  -- from clause
  -- where clause
  -- group by clause
  -- having clause  
  -- order by clause   
  -- select   


--Functions to the RHS of a where clause will not work
SELECT *
FROM tblemployees
WHERE Salary > AVG(Salary);

--- Q.1.> Dept wise Avg Salary
SELECT DeptNo AS 'Department', AVG(Salary) AS 'Average Salary'
FROM tblemployees
GROUP BY DeptNo;

--- Q.2.> Count the no.of male and female employees
SELECT Gender, COUNT(*) AS 'NO OF EMPLOYEES'
FROM tblemployees
GROUP BY Gender;

--Insert new values
INSERT INTO tblemployees 
VALUES  (113, 'Kajal',    'Female', 6500, 4, 56272211),
		(110, 'Shreyash', 'Male',   6520, 5, 768989), 
		(115, 'Naman',    'Male',	6455, 5, 0967879),
		(114, 'Vijendra', 'Male',	6520, 4, 09892765),
		(120, 'vaishnavi','Female',	6450, 5, 0988765);

SELECT * FROM tblemployees;

--- Q.3.> Dept wise no. of male and female employees
SELECT DeptNo, Gender, COUNT(*) AS 'NO OF EMPLOYEES'
FROM tblemployees
GROUP BY DeptNo, Gender
ORDER BY DeptNo, Gender;

UPDATE tblemployees 
SET Gender = 'Female'
WHERE Empid = 107;

SELECT * FROM tblemployees WHERE Gender IS NULL;

--- Q.4.> Dept wise, no. of male and female employees where the count is > 1
SELECT DeptNo, Gender, COUNT(*) AS 'NO OF EMPLOYEES'
FROM tblemployees
GROUP BY DeptNo, Gender
HAVING COUNT(*) > 1
ORDER BY DeptNo;

--- Q.5.> Dept wise average salary having average salary > 6300
SELECT DeptNo, AVG(Salary) AS 'Average Salary'
FROM tblemployees
WHERE DeptNo IS NOT NULL
GROUP BY DeptNo
HAVING AVG(Salary) > 6300
ORDER BY DeptNo DESC;

SELECT * FROM tblDepartment;
SELECT * FROM tblemployees;

--JOINING 2 TABLES:-
  --Department name wise total salary where total salary > 13000
  -- The above query involves 2 tables
  -- We will need to join the tables

--- Q.6.> Joining 2 tables to get the expected output
SELECT DeptName, SUM(Salary) AS 'Total Salary for Dept'
FROM tblDepartment, tblemployees
WHERE tblDepartment.DeptNo = tblemployees.DeptNo
GROUP BY DeptName
HAVING SUM(Salary) > 13000;

--- Q.7.> Joining 2 tables and qualifying with thier original names
SELECT tblDepartment.DeptName, SUM(Salary) AS 'Total Salary for Dept'
FROM tblDepartment, tblemployees
WHERE tblDepartment.DeptNo = tblemployees.DeptNo
GROUP BY tblDepartment.DeptName
HAVING SUM(Salary) > 13000;

--- Q.8.> Joining 2 tables and qualifying with their alias names
SELECT T1.DeptName, SUM(Salary) AS 'Total Salary for Dept'
FROM tblDepartment T1, tblemployees T2
WHERE T1.DeptNo = T2.DeptNo
GROUP BY T1.DeptName
HAVING SUM(Salary) > 13000;

--- JOIN
-- Cross Joins (cartesian product)
-- Inner Join  (Natural/Equi)
-- Outer Join  ( left,right,full)
-- Self Join  (join a table with itself)

--- Q.1.> Cross Join :-
SELECT * FROM tblemployees, tblDepartment;
--OR
SELECT * FROM tblemployees CROSS JOIN tblDepartment;

--- Q.2.> Inner Join
SELECT td.DeptName, td.Loc, te.Empname, te.Salary
FROM tblDepartment td, tblemployees te
WHERE td.DeptNo = te.DeptNo;
---OR
SELECT td.DeptName, td.Loc, te.Empname, te.Salary
FROM tblDepartment td JOIN tblemployees te
ON td.DeptNo = te.DeptNo;

--- Q.3.> Outer Join
INSERT INTO tblDepartment
VALUES (7,'Sales',450000,'Kolkatta');

SELECT * FROM tblDepartment;
SELECT * FROM tblemployees;

--Right || Left outer join -all matching records/rows from both the tables and non matching rows from 
 --the Right || Left hand side table
 SELECT td.DeptName, td.Loc, te.Empname, te.Salary
FROM tblDepartment td LEFT OUTER JOIN tblemployees te
ON td.DeptNo = te.DeptNo;
--OR
 SELECT td.DeptName, td.Loc, te.Empname, te.Salary
FROM tblDepartment td RIGHT OUTER JOIN tblemployees te
ON td.DeptNo = te.DeptNo;

--full outer join - all matching records/rows from both the tables and non matching rows from 
 --The left hand side table and also non-matching rows of the right hand side table
  SELECT td.DeptName, td.Loc, te.Empname, te.Salary
FROM tblDepartment td FULL OUTER JOIN tblemployees te
ON td.DeptNo = te.DeptNo;

--Display all the supervisor names and their subordinate names

--- Q.4.> Self Join

SELECT 
    t1.empname AS 'Supervisor Name', 
    t2.empname AS 'Subordinates Name'
FROM 
    tblemployees t1 
JOIN 
    tblemployees t2 
ON 
    t1.empid = t2.mgrid;

 --Sub queries

--- Q.1.> Display all employees who have salaries greater than Ayesha
SELECT salary FROM tblemployees WHERE empname like 'ayesha';

SELECT Empname, Salary
FROM tblemployees 
WHERE Salary>6300;

--OR

SELECT Empname, Salary
FROM tblemployees 
WHERE Salary>(SELECT salary FROM tblemployees WHERE empname like 'ayesha');
 
 -- Q.2.> With name 
	i.)   ANY
		SELECT Empname, Salary
		FROM tblemployees
		WHERE Salary > ANY (SELECT salary FROM tblemployees WHERE empname like 'A%');

	ii.)  ALL
		SELECT Empname, Salary
		FROM tblemployees
		WHERE Salary > ALL (SELECT salary FROM tblemployees WHERE empname like 'A%');

	iii.) IN
		SELECT Empname, Salary
		FROM tblemployees
		WHERE Salary IN (SELECT salary FROM tblemployees WHERE empname like 'A%');

--- Q.3.> List of employees who works in the deptno as that of 103 and earns salary > than 106
SELECT Empname, Salary
FROM tblemployees
WHERE DeptNo = (SELECT DeptNo FROM tblemployees WHERE Empid=103) 
  AND Salary > (SELECT Salary FROM tblemployees WHERE Empid=108)
		
--- Q.4.> Using group functions in subquery
SELECT Empname, Salary, Gender
FROM tblemployees
WHERE SALARY > (SELECT AVG(Salary) FROM tblemployees);

--- Q.5.> Having clause with subqueries
select deptno, min(salary) from tblemployees
group by deptno
having min(salary) >
                  (select min(salary) from tblemployees where deptno = 4)


-----------------------------------------		SQL 3	---------------------------------------------------

--Second highest problems are solved using corelated sub query

--Second highest Salary
SELECT Empname, Salary
FROM tblemployees
ORDER BY Salary DESC;

SELECT e.Empname, e.Salary
FROM tblemployees e
WHERE 2 = (
	SELECT COUNT(Salary)
	FROM tblemployees e2
	WHERE e2.Salary >= e.Salary
		  );

--Replacing Correlated Subqueries with Joins for Better Performance
--Q1.> Find all employees whose salary is greater than the average salary of that department
-- Using a Correlated Subquery:
SELECT e1.Empid, e1.Empname, e1.Salary
FROM tblemployees e1
WHERE Salary > (
			SELECT AVG(Salary)
			FROM tblemployees e2
			WHERE e2.DeptNo = e1.DeptNo
			   );

--Using an Inner Join:
SELECT e1.Empid, e1.Empname, e1.Salary
FROM tblemployees e1
JOIN (
	SELECT DeptNo, AVG(Salary) AS 'Dept Salary'
	FROM tblemployees
	GROUP BY DeptNo
	 ) AS T ON e1.DeptNo = T.DeptNo
	 WHERE e1.Salary > T.[Dept Salary];

--Corelated sub query for updation
SELECT * FROM tblDepartment;
SELECT * FROM tblemployees;

--Q2.> update salary for all employees, whose salary is minimum in that departement
UPDATE tblemployees 
SET Salary = 6000
WHERE Empid = 200;

UPDATE tblemployees
SET Salary = Salary + 20
FROM tblemployees t1
WHERE Salary <= (
			 SELECT MIN(t2.Salary)
			 FROM tblemployees t2
			 WHERE t2.DeptNo = t1.DeptNo
				);

SELECT Empname, Salary
FROM tblemployees;

--Bulk Insertion
CREATE TABLE dummy1(
				   did int,
				   dname VARCHAR(10)
				   );
			
ALTER  TABLE dummy1
ADD daddress VARCHAR(10);

CREATE TABLE dummy2(
				id int,
				dummyname VARCHAR(10),
				dphone VARCHAR(5),
				dcity VARCHAR(6),
				dsal float
				);

INSERT INTO dummy1
VALUES (1,'A', NULL),(2,'B',NULL),(3,'C',NULL),(4,'D',NULL);

UPDATE dummy1 set daddress = 'Infinite';

Select * from dummy1;
Select * from dummy2;

-- source having more columns than destination
insert into dummy2(id, dummyname) select did,dname from dummy1 

--destination having more columns than source, then we need to specify 
--the column list for insertion
insert into dummy2(id, dummyname) select did,dname from dummy1 

--identity column
CREATE TABlE Sample1(
				S_id int IDENTITY(2,2),
				Sname VARCHAR(5)
				);

SP_HELP SAMPLE1;

SP_HELP tblemployees;

INSERT INTO Sample1
VALUES ('BCOM');

Select * from sample1
delete from sample1 where s_id=2

--drop vs truncate vs delete
CREATE TABLE test(
				tid INT,
				tname char(5)
				);

INSERT INTO test 
VALUES (1,'g'),(2,'p'),(3,'o');

select * from test

drop TABLE test
truncate TABLE test

delete from test
where tid > 1;

begin tran
	delete from test
	where tid > 1
	rollback

--Hard delete vs Soft delete
-- Hard delete: This will permanently remove the record where deptno=1
DELETE FROM tbldepartment WHERE deptno=1;

-- Soft delete: This will mark the record as deleted by updating the deptno
UPDATE tblDepartment SET DeptNo = 0 WHERE DeptNo = 1;

-- Alternatively, if you have a status column to indicate deletion:
UPDATE tbldepartment SET status='inactive' WHERE deptno=1;

select * from tblDepartment

-- Another example

ALTER TABLE tblemployees
ADD remarks1 VARCHAR(MAX);

SELECT * FROM tblemployees;

update tblemployees 
set remarks1 =
		case
			when  Empid=101 then 'aa'
			when  Empid=102 then 'ab'
			when  Empid=103 then 'ac'
			when  Empid=105 then 'ad'
			when  Empid=106 then 'ae'
		end;

-- Soft delete: This will mark the record as deleted by updating the deptno
UPDATE tblemployees SET remarks1 = 'áb1' WHERE remarks1 = 'aa';
UPDATE tblemployees SET remarks1 = 'áb2' WHERE remarks1 = 'ab';
UPDATE tblemployees SET remarks1 = 'áb3' WHERE remarks1 = 'ac';

-- Alternatively, if you have a status column to indicate deletion:
UPDATE tblemployees SET remarks1 ='inactive' WHERE remarks1 = 'ad';

SELECT * FROM tblemployees;

UPDATE tblemployees SET remarks1 ='ad' WHERE remarks1 = 'inactive';

ALTER TABLE tblemployees 
DROP COLUMN remarks1;

-- Case
CREATE TABLE casetable(cid int, cname varchar(20));

INSERT INTO casetable VALUES (5, 'White'),(3,'Blue'),(2,'Green'),(4,'Red');

SELECT * FROM casetable;

--Simple Case without else
SELECT cid, cname,
	CASE cname
		WHEN 'Red'   THEN 'Danger'
		WHEN 'Blue'  THEN 'Primary'
		WHEN 'Green' THEN 'Success'
	END AS Remarks
FROM casetable;

 --case with else
SELECT cid, cname,
	CASE cname
		WHEN 'Red'   THEN 'Danger'
		WHEN 'Blue'  THEN 'Primary'
		WHEN 'Green' THEN 'Success'
	ELSE 'NO Comments'
	END AS 'Color Remarks'
FROM casetable;

 --searched case with else
SELECT cid, cname,
	CASE 
		WHEN cname = 'Red'   THEN 'Danger'
		WHEN cname = 'Blue'  THEN 'Primary'
		WHEN cname = 'Green' THEN 'Success'
	ELSE  'Incorrect Color'
	END AS ColorStatus
FROM casetable;

--t-sql (transact sql)helps us to use programming constructs viz.
--1. variables
--2. if else
--3. case
--4. while
--5. break and continue

--nested case example with details:--
-- Step 1: Declare the variable
DECLARE @totsales INT;
-- Step 2: Set the variable value
SET @totsales = 530;
-- Step 3: Check the output
SELECT @totsales AS TotalSales;

--nested case
DECLARE @totsales INT;
SET @totsales = 530;
SELECT CASE
	WHEN @totsales >= 500 THEN 'Bumper Sales'
	WHEN @totsales <  500 THEN 
		CASE
			WHEN @totsales between 100 and 200 THEN 'Poor Sales'
			WHEN @totsales between 201 and 300 THEN 'Ok Sales'
			WHEN @totsales between 301 and 400 THEN 'Good Sales'
			ELSE 'No Sales'
		END
	END AS SalesData;

 --nested case inside if else
declare @sales int
set @sales=245
select @sales as 'Total Sales'

print 'The Total Sales made is ' + ' ' + cast(@sales as varchar(5))
if @sales >300
   select 'Bumper Sales'
else
   begin 
     select case
		when @sales between 100 and 200 then 'Poor Sales'
		when @sales between 201 and 300 then 'OK Sales'
		when @sales between 301 and 400 then 'Good Sales'
		else 'No Sales'
		end 'Sales Status'
	end;

--Q.1> 
BEGIN
DECLARE @v   INT = 50,
		@v2  INT = 100,
		@sum INT
SET @sum = @v + @v2;

PRINT 'The sum of 2 nos is ' + CAST(@sum AS VARCHAR(5))

IF(@v > @v2)
	PRINT 'v IS BIG.'
ELSE
	PRINT 'v2 IS BIG.'
END;

--Q.2>
--using tsql increase the salary by 100/- for all employees 
--who earn less than 103 empid
BEGIN
	DECLARE @sal FLOAT
	DECLARE @ename VARCHAR(30)
SELECT  @ename = Empname,
		@sal = Salary
FROM tblemployees
WHERE Empid = 102

PRINT 'Name of the employee : ' + @ename
PRINT 'Salary is :' + cast(@sal as varchar(10))

  IF(@sal <= 6200)
	  BEGIN
		SET @sal = @sal + 100
	    PRINT 'Revised Salary ' + CAST(@sal AS VARCHAR(10))

-- Update the employee's salary in the database (iF WANT TO)
        UPDATE tblemployees
        SET salary = @sal
        WHERE empid = 102;

	  END
  ELSE
	  BEGIN
	    PRINT 'Salary Is OK.'
	  END
  END;

SELECT * FROM tblemployees

--while
declare @ctr int = 1;
while @ctr <= 5
  begin
    print @ctr
  set @ctr = @ctr + 1;
end;

  --while with break
declare @ctr1 int = 0
  while @ctr1 <= 5
   begin
     set @ctr1 = @ctr1 + 1;
   if @ctr1 = 4
   break
     print @ctr1   
end;
 
 --while with continue
declare @ctr2 int = 0
while @ctr2 <= 5
 begin
   set @ctr2 = @ctr2 + 1;
 if @ctr2 = 4
 continue
   print @ctr2   
  end;

--set commands
--union and union all
CREATE TABLE utable1(
				tid INT IDENTITY,
				tname VARCHAR(30),
				tgrade CHAR(1),
				tpercentage INT
				);

INSERT INTO utable1 
VALUES  ('Nithin','A',85),
		('Pratheeba','A',80),
		('Raghav','B',65),
		('Raghu','B',60);

CREATE TABLE utable2(
				tid INT IDENTITY,
				tname VARCHAR(30),
				tgrade CHAR(1),
				tpercentage INT
				);

DELETE FROM utable2;

INSERT INTO utable2
VALUES  ('Ritesh','A',85),
		('Saivardhan','A',80),
		('Jahnavi','B',65),
		('Kajal','B',63);

SELECT * FROM utable1;
SELECT * FROM utable2;

SELECT tgrade, tpercentage, tname
FROM utable1
WHERE tname LIKE 'R%'
UNION ALL
SELECT tgrade, tpercentage, tname
FROM utable2
-- use this line when need output only for R name
WHERE tname LIKE 'R%';

SELECT tgrade, tpercentage, tname
FROM utable1
WHERE tname LIKE 'R%'
UNION 
SELECT tgrade, tpercentage, tname
FROM utable2;

--intersect
CREATE TABLE empdetails(
					Id INT IDENTITY,
					EName VARCHAR(30),
					Age INT,
					City VARCHAR(20)
					);

INSERT INTO empdetails
VALUES ('Suresh',24,'Delhi'),('Ramesh',23,'Pune'),('Vijesh',30,'Kolkatta');

CREATE TABLE Bonusdata(
					Bonussld INT,
					Eid	INT,
					bonusAmt INT
					);

INSERT INTO Bonusdata
VALUES (20,5,10000),(15,3,30000);

SELECT * FROM empdetails;
SELECT * FROM Bonusdata;

SELECT Id, EName, bonusAmt
FROM empdetails
LEFT JOIN Bonusdata ON empdetails.Id = Bonusdata.Eid
INTERSECT
SELECT Id, EName, bonusAmt
FROM empdetails
RIGHT JOIN Bonusdata ON empdetails.Id = Bonusdata.Eid;

--except
SELECT Id, EName, bonusAmt
FROM empdetails
LEFT JOIN Bonusdata ON empdetails.Id = Bonusdata.Eid
EXCEPT
SELECT Id, EName, bonusAmt
FROM empdetails
RIGHT JOIN Bonusdata ON empdetails.Id = Bonusdata.Eid;



-----------------------------------------		SQL 4	---------------------------------------------------

--Common Table Expression (CTE) : Allows us to define a named temporary result set that is available within the execution scope





















-----------------------------------------		SQL 5	---------------------------------------------------























-----------------------------------------		SQL 6	---------------------------------------------------


























-----------------------------------------		SQL 7	---------------------------------------------------






















-----------------------------------------		SQL 8	---------------------------------------------------






































