--CREATE DATABASE <DATABASENAME>
CREATE DATABASE Rnet104University

--USE <DATABASENAME>
USE Rnet104University

--DROP DATABASE <DATABASENAME>
USE master
DROP DATABASE Rnet104University

CREATE TABLE Students(
	StudentId INT PRIMARY KEY,
	FirstName NVARCHAR(50),
	LastName NVARCHAR(50),
	BirthDate DATE,
	Email NVARCHAR(100)
);

--DROP TABLE <TableName>
DROP TABLE Teachers
CREATE TABLE Teachers (
    TeacherID INT IDENTITY ,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    HireDate DATE,
    Department NVARCHAR(50),
    Email NVARCHAR(100)
);

DROP TABLE Courses
CREATE TABLE Courses (
    CourseID INT IDENTITY,
    CourseName NVARCHAR(100),
    Credits INT,
);

--INSERT INTO <TableName> (Columns' names) VALUES(Value1ForColumn1,...,ValueNForColumnN)

--INSERT INTO <TableName>

INSERT INTO Students (StudentID, FirstName, LastName, BirthDate)
VALUES (1, 'Ali', 'Məmmədov', '2000-03-15'),
       (2, 'Leyla', 'Hüseynova', '1999-07-22');

SELECT * FROM Students
SELECT StudentId,FirstName + ' ' + LastName as Fullname FROM Students


INSERT INTO Teachers 
VALUES ('Test', 'Testov', '2015-08-01', 'Computer Science', 'zaur.aliyev@example.com'),
       ('Gülnar', 'Sadıqova', '2010-02-14', 'Mathematics', 'gulnar.sadiqova@example.com');

SELECT * FROM Teachers

INSERT INTO Courses ( CourseName, Credits)
VALUES ( 'Database Systems', 4),
       ( 'Calculus I', 3);

--ALTER TABLE <TableName> ADD NewColumnName Column'sType

ALTER TABLE Students
ADD PhoneNumber NVARCHAR(15)

--UPDATE <TableName> SET <ColumnName> = myData
UPDATE Students
SET PhoneNumber = '+994502888888'
WHERE StudentId = 2

--DELETE <TableName>
DELETE Students
WHERE StudentId = 2