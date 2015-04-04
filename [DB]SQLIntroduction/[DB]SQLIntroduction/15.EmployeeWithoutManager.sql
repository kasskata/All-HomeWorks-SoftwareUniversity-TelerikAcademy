SELECT
	e.FirstName,
	e.LastName,
	e.EmployeeID
FROM Employees e
WHERE e.ManagerID IS NULL