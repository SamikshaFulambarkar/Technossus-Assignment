create database Technossus_Assignment;
use Technossus_Assignment;

create table Students
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	StudentName NVARCHAR(255) NOT NULL,
	FatherName NVARCHAR(255),
	MotherName NVARCHAR(255),
	Age INT,
	HomeAddress NVARCHAR(255),
	RegistrationDate DATETIME,
	IsDeleted BIT DEFAULT 0
);

select * from Students;

create table SoftDeletes
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	TableName NVARCHAR(255) NOT NULL,
	RecordId INT,
	DeletedAt DATETIME
);

select * from SoftDeletes;

