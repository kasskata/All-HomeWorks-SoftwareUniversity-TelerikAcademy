--01. Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
SELECT
	e.FirstName + ' ' + e.LastName,
	e.Salary
FROM Employees e
WHERE e.Salary = (SELECT
	MIN(Salary)
FROM Employees)

--02.Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.
SELECT
	FirstName + ' ' + LastName,
	Salary
FROM Employees
WHERE Salary <= (SELECT
	MIN(Salary)
FROM Employees)
+ ((SELECT
	MIN(Salary)
FROM Employees)
* 0.10)
ORDER BY Salary DESC

--03.Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department.
SELECT
	FirstName + ' ' + LastName AS Name,
	Salary
FROM Employees e
JOIN Departments d
	ON d.DepartmentID = e.DepartmentID
WHERE Salary = (SELECT
	MIN(Salary)
FROM Employees
WHERE DepartmentID = e.DepartmentID)
ORDER BY d.DepartmentID

--04.Write a SQL query to find the average salary in the department #1.
SELECT
	AVG(Salary) AS [Average Salary]
FROM Employees
WHERE DepartmentID = 1

--05.Write a SQL query to find the average salary in the "Sales" department.
SELECT
	AVG(e.Salary) AS [Sale Department Average Salary]
FROM Employees e
JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

--06.Write a SQL query to find the number of employees in the "Sales" department.
SELECT
	COUNT(e.EmployeeID)
FROM Employees e
JOIN Departments d
	ON d.DepartmentID = e.DepartmentID
WHERE d.Name = 'Sales'

--07.Write a SQL query to find the number of all employees that have manager.
SELECT
	COUNT(e.EmployeeID)
FROM Employees e
WHERE e.ManagerID IS NOT NULL

--08.Write a SQL query to find all departments and the average salary for each of them.
SELECT
	d.Name AS [Department],
	AVG(e.Salary) AS [Average Salary]
FROM Departments d
JOIN Employees e
	ON d.DepartmentID = e.DepartmentID
GROUP BY d.Name

--09.Write a SQL query to find the count of all employees in each department and for each town.
SELECT
	COUNT(e.EmployeeID) AS [Number of Employees],
	d.Name AS [Town/Dept.]
FROM Employees e
INNER JOIN Departments d
	ON d.DepartmentID = e.DepartmentID
GROUP BY d.Name
UNION
SELECT
	COUNT(e.EmployeeID) AS [Town Employees Count],
	t.Name AS [Town/Dept.]
FROM Employees e
INNER JOIN Addresses a
	ON e.AddressID = a.AddressID
INNER JOIN Towns t
	ON a.TownID = t.TownID
GROUP BY t.Name

--10.Write a SQL query to find all managers that have exactly 5 employees.
SELECT
	COUNT(e.ManagerID) AS [Employee Count],
	MIN(e.FirstName) + ' ' + MIN(e.LastName) AS [Manager Name]
FROM Employees e
GROUP BY e.ManagerID
HAVING COUNT(e.ManagerID) = 5

--11.Write a SQL query to find all employees along with their managers.
SELECT
	e.FirstName + ' ' + e.LastName,
	ISNULL(m.FirstName + ' ' + m.LastName, 'no manager')
FROM Employees e
LEFT JOIN Employees m
	ON m.EmployeeID = e.ManagerID

--12.Write a SQL query to find the names of all employees whose last name is exactly 5 characters long.
SELECT
	e.FirstName,
	e.LastName
FROM Employees e
WHERE LEN(e.LastName) = 5

--13.Write a SQL query to display the current date and time in the following format "day.month.year hour:minutes:seconds:milliseconds". 
SELECT
	FORMAT(GETDATE(), 'dd.MM.yyyy HH:mm:s:ffff')

--14.Write a SQL statement to create a table Users. Users should have username, password, full name and last login time. Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint. Define the primary key column as identity to facilitate inserting records. Define unique constraint to avoid repeating usernames. Define a check constraint to ensure the password is at least 5 characters long.
CREATE TABLE Users (
	Id INT PRIMARY KEY IDENTITY (1, 1),
	Username NVARCHAR(50) UNIQUE,
	Password NVARCHAR(50),
	FullName NVARCHAR(100),
	LastLoggedIn DATETIME NULL,
	CONSTRAINT check_Password CHECK (LEN(Password) > 5)
)

--15.Write a SQL statement to create a view that displays the users from the Users table that have been in the system today.
SELECT
	*
FROM Users
WHERE FORMAT(LastLoggedIn, 'dd-MM-yyyy') = FORMAT(GETDATE(), 'dd-MM-yyyy')

--16.Write a SQL statement to create a table Groups.
CREATE TABLE Groups (
	Id INT IDENTITY (1, 1) NOT NULL,
	Name NVARCHAR(50) UNIQUE NOT NULL
)

--17.Write a SQL statement to add a column GroupID to the table Users.
ALTER TABLE Users ADD ColumnID INT
FOREIGN KEY (ColumnID) REFERENCES Users (Id)
GO
--18.Write SQL statements to insert several records in the Users and Groups tables.
INSERT INTO Groups (Name)
	VALUES ('Pesho')
INSERT INTO Groups (Name)
	VALUES ('Gosho')
INSERT INTO Groups (Name)
	VALUES ('Mitio')
INSERT INTO Groups (Name)
	VALUES ('Mimi')

INSERT INTO Users (Username, Password, FullName, LastLoggedIn)
	VALUES ('Pesho', '12345678', 'Pesho Georgiev', GETDATE())
INSERT INTO Users (Username, Password, FullName, LastLoggedIn)
	VALUES ('Gosho', '12345678', 'Pesho Georgiev', GETDATE())
INSERT INTO Users (Username, Password, FullName, LastLoggedIn)
	VALUES ('Misho', '12345678', 'Pesho Georgiev', GETDATE())

--19.Write SQL statements to update some of the records in the Users and Groups tables.
UPDATE Users
SET	Username = 'Haralampi',
	LastLoggedIn = '10-02-2010'
WHERE FullName = 'Kevin Brown'
UPDATE Groups
SET Name = 'Haralampi'
WHERE Name = 'Gosho'

--20.Write SQL statements to delete some of the records from the Users and Groups tables.
DELETE FROM Users
WHERE Username = 'Haralampi'
DELETE FROM Groups
WHERE Name = 'Haralampi'

--21.Write SQL statements to insert in the Users table the names of all employees from the Employees table
INSERT INTO Users (FullName, Password, Username, LastLoggedIn)
	SELECT
		Employees.FirstName + ' ' + Employees.LastName,
		Employees.FirstName + ' ' + Employees.LastName + CONVERT(NVARCHAR(10), Employees.EmployeeID),
		Employees.FirstName + ' ' + CONVERT(VARCHAR(10), EmployeeID),
		GETDATE()
	FROM Employees

--22.Write a SQL statement that changes the password to NULL for all users that have not been in the system since 10.03.2010.
UPDATE Users
SET Password = NULL
WHERE LastLoggedIn < '10-03-2010'

--23.Write a SQL statement that deletes all users without passwords (NULL password).
DELETE FROM Users
WHERE Password IS NULL

--24.Write a SQL query to display the average employee salary by department and job title.
SELECT
	'$ ' + CONVERT(NVARCHAR(20),
	AVG(e.Salary)) AS [Average Salary],
	MIN(d.Name) AS [Department],
	MIN(e.JobTitle) AS [JobTitle]
FROM Employees e
JOIN Departments d
	ON d.DepartmentID = e.DepartmentID
GROUP BY	e.DepartmentID,
			e.JobTitle
ORDER BY e.DepartmentID, e.JobTitle

--25.Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it.
SELECT
	MIN(e.Salary) AS [Minimum Salary],
	MIN(d.Name) AS [Dept. Name],
	MIN(e.JobTitle) AS [Job Title],
	MIN(e.FirstName) + ' ' + MIN(e.LastName) AS [Employee name]
FROM Employees e
JOIN Departments d
	ON d.DepartmentID = e.DepartmentID
GROUP BY	e.DepartmentID,
			e.JobTitle
ORDER BY MIN(e.Salary) ASC, e.DepartmentID, e.JobTitle

--26.Write a SQL query to display the town where maximal number of employees work.
SELECT TOP 1
	*
FROM (SELECT
	COUNT(e.EmployeeID) AS [EmployeeCount],
	t.Name AS [Name]
FROM Employees e
INNER JOIN Addresses a
	ON a.AddressID = e.AddressID
INNER JOIN Towns t
	ON t.TownID = a.TownID
GROUP BY t.Name) c
ORDER BY c.EmployeeCount DESC

--27.Write a SQL query to display the number of managers from each town.
SELECT
	COUNT(e.EmployeeID) AS [Manager Count],
	t.Name AS [City Name]
FROM Employees e
INNER JOIN Addresses a
	ON a.AddressID = e.AddressID
INNER JOIN Towns t
	ON t.TownID = a.TownID
INNER JOIN Employees m
	ON m.EmployeeID = e.ManagerID
GROUP BY t.Name
ORDER BY t.Name DESC

-- test Queey for request
SELECT
	*
FROM Towns
WHERE Name = 'Cambridge'
SELECT
	*
FROM Addresses
WHERE TownID = 23

--28.Write a SQL to create table WorkHours to store work reports for each employee.Each employee should have id, date, task, hours and comments. Don't forget to define identity, primary key and appropriate foreign key.
CREATE TABLE WorkHours (
	Id INT IDENTITY (1, 1) PRIMARY KEY,
	[Date] DATETIME,
	Task NVARCHAR(100),
	[Hours] INT,
	[Comment] TEXT,
	[EmployeeID] INT FOREIGN KEY REFERENCES Employees (EmployeeID)
)

--29.Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers

CREATE TRIGGER trg_WorkHoursChanged
ON WorkHours
INSTEAD OF INSERT, DELETE, UPDATE
AS
BEGIN
	SET NOCOUNT ON;
END
GO

--30.Start a database transaction, delete all employees from the 'Sales' department along with all dependent records from the pother tables. At the end rollback the transaction.

ALTER TABLE Employees
	DROP CONSTRAINT FK_Employees_Employees
	GO
	ALTER TABLE Employees
	ADD CONSTRAINT FK_Employees_Employees FOREIGN KEY (ManagerID)
	REFERENCES Employees (EmployeeID)
	ON DELETE CASCADE
	ON UPDATE NO ACTION
	GO

BEGIN TRANSACTION
	

	BEGIN TRY
		BEGIN TRANSACTION

		COMMIT
	END TRY
	BEGIN CATCH

		IF @@trancount > 0
			ROLLBACK
	END CATCH
COMMIT TRANSACTION