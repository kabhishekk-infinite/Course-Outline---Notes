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

			

