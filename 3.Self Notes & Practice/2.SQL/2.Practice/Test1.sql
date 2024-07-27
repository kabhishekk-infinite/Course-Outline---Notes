
-- Create the database
CREATE DATABASE Test1;

-- Use the database
USE Test1;
	
-- Create Table
CREATE TABLE Customers(
	ID Int PRIMARY KEY,
	FName Varchar(50),
	LName Varchar(50),
	Country Varchar(50)
);

CREATE TABLE Orders(
	ID Int Primary Key,
	OrderDate Date,
	CustomerID Int,
	Total Decimal(10,2),
	FOREIGN KEY (CustomerID) REFERENCES Customers(ID)
);

-- View Values of Table
SELECT * FROM Customers;
SELECT * FROM Orders;

-- Modify Table
ALTER TABLE Customers
ADD Email Varchar(100);

CREATE TABLE Products(
	PName Varchar(50),
	PRate Decimal(10,2)
	);

-- Check
SELECT * FROM Products;

-- Drop Table
DROP TABLE Products;

-- Again create Table
CREATE TABLE Products(
	PName Varchar(50),
	PRate Decimal(10,2)
	);

ALTER TABLE Products
ADD TBill Decimal(10,2);

ALTER TABLE Products
ADD PID Int;

--To delete column
ALTER TABLE Products
DROP COLUMN PID;

ALTER TABLE Products
ADD ProID Int;

-- To make any column primary key , first define it null.

ALTER TABLE Products
ALTER COLUMN ProID INT not NULL;

ALTER TABLE Products
ADD CONSTRAINT PK_ProID PRIMARY key (ProID);


-- Now assume this db as school :--

USE Test1;

-- create table and add value into it.

CREATE TABLE Students(
	SID INT PRIMARY KEY,
	FName Varchar(50),
	LName Varchar(50),
	DOB Date
	);

CREATE TABLE Courses(
	CID INT PRIMARY KEY,
	CName Varchar(50),
	Credits INT
	);

CREATE TABLE ENROLL(
	SID INT,
	CID INT,
	EDate DATE,
	PRIMARY KEY (SID, CID),
	FOREIGN KEY (SID) REFERENCES Students(SID),
	FOREIGN KEY (CID) REFERENCES Courses(CID)
	);


Select * From Students;
Select * From  Courses;
Select * From  ENROLL;

INSERT INTO Students(SID, FName, LName, DOB)
VALUES	(1, 'Abhishek', 'Kumar', '2000-07-27'),
		(2, 'Ankit', 'Raj', '2001-04-23');


INSERT INTO Courses(CID, CName, Credits)
VALUES	(101, 'Cyber Security', 92),
		(102, 'Sales', 88);

INSERT INTO ENROLL(SID, CID, EDate)
VALUES	(1, 101, '2024-05-01'),
		(2, 102, '2024-05-01');


Select * From Students;
Select * From  Courses;
Select * From  ENROLL;