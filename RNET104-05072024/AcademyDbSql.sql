-- Create Academy Database
CREATE DATABASE AcademyDb1;
GO

-- Use Academy Database
USE AcademyDb1;
GO

-- Create Students Table
CREATE TABLE Students (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(50) NOT NULL,
    EnrollmentDate DATE NOT NULL
);
GO

-- Create Departments Table
CREATE TABLE Departments (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    DepartmentName NVARCHAR(100) NOT NULL
);
GO

-- Create Instructors Table
CREATE TABLE Instructors (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    HireDate DATE NOT NULL,
    DepartmentId INT NOT NULL,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(50) NOT NULL,
    PIN NVARCHAR(10) NOT NULL,
    CONSTRAINT FK_Instructors_DepartmentId FOREIGN KEY (DepartmentId) REFERENCES Departments(Id)
);
GO

-- Create Groups Table
CREATE TABLE Groups (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    GroupName NVARCHAR(100) NOT NULL,
    DepartmentId INT NOT NULL,
    StartDate DATE NOT NULL,
    EndDate DATE NOT NULL,
    CONSTRAINT FK_Group_DepartmentId FOREIGN KEY (DepartmentId) REFERENCES Departments(Id)
);
GO

-- Create Enrollments Table
CREATE TABLE Enrollments (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    StudentId INT NOT NULL,
    GroupId INT NOT NULL,
    CONSTRAINT FK_Enrollments_StudentId FOREIGN KEY (StudentId) REFERENCES Students(Id),
    CONSTRAINT FK_Enrollments_GroupId FOREIGN KEY (GroupId) REFERENCES [Groups](Id)
);
GO

-- Create Classes Table
CREATE TABLE Classes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    GroupId INT NOT NULL,
    InstructorId INT NOT NULL,
    Schedule NVARCHAR(50) NOT NULL,
    RoomName NVARCHAR(50) NOT NULL,
    CONSTRAINT FK_Classes_CourseId FOREIGN KEY (GroupId) REFERENCES [Groups](Id),
    CONSTRAINT FK_Classes_InstructorId FOREIGN KEY (InstructorId) REFERENCES Instructors(Id)
);
GO



INSERT INTO Students (FirstName, LastName, DateOfBirth, Username, Password, EnrollmentDate)
VALUES 
('John', 'Doe', '2000-01-01', 'johndoe', 'password123', '2023-09-01'),
('Jane', 'Smith', '1999-05-15', 'janesmith', 'password456', '2023-09-01');

INSERT INTO Departments (DepartmentName)
VALUES 
('Computer Science'),
('Mathematics'),
('Physics');

INSERT INTO Instructors (FirstName, LastName, HireDate, DepartmentId, Username, Password, PIN)
VALUES 
('Alice', 'Johnson', '2020-08-01', 1, 'alicej', 'securepass', '1234'),
('Bob', 'Brown', '2019-07-15', 2, 'bobb', 'mypassword', '5678');

INSERT INTO GroupS (GroupName, DepartmentId, StartDate, EndDate)
VALUES 
('CS101', 1, '2023-09-01', '2024-06-30'),
('Math201', 2, '2023-09-01', '2024-06-30');

INSERT INTO Enrollments (StudentId, GroupId)
VALUES 
(1, 2),
(2, 2);

INSERT INTO Classes (GroupId, InstructorId, Schedule, RoomName)
VALUES 
(1, 1, 'Mon/Wed/Fri 10:00-11:00', 'Room 101'),
(2, 2, 'Tue/Thu 09:00-10:30', 'Room 202');



SELECT s.Id, s.FirstName, s.LastName, g.GroupName, c.Schedule, c.RoomName
FROM Enrollments e
JOIN Students s ON e.StudentId = s.Id
JOIN Groups g ON e.GroupId = g.Id
JOIN Classes c ON g.Id = c.GroupId
WHERE s.Id = 1