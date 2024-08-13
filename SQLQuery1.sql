USE master;
GO

IF NOT EXISTS (
   SELECT name
   FROM sys.databases
   WHERE name = N'weng'
)
CREATE DATABASE [weng];
GO

USE [weng];

IF OBJECT_ID('dbo.Attendance', 'U') IS NOT NULL
    DROP TABLE dbo.Attendance;
GO

IF OBJECT_ID('dbo.hello', 'U') IS NOT NULL
    DROP TABLE dbo.hello;
GO

CREATE TABLE hello (
    RFID INT NOT NULL PRIMARY KEY, 
    Name NVARCHAR(50) NOT NULL,
    Section NVARCHAR(50) NOT NULL
);
GO

INSERT INTO hello
   ([RFID], [Name], [Section])
VALUES
   (28, N'weng', N'TVL 12'),
   (12, N'Siaron', N'TVL 12'),
   (16, N'Mark', N'TVL 12');
GO

SELECT * FROM hello;
GO

