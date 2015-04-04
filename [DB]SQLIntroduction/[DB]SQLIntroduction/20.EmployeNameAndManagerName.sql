SELECT
	e.FirstName + ' ' + e.LastName as [Employee],
	e.ManagerID AS [ManagerId],
	m.EmployeeID as [Employee Id],
	m.FirstName AS [Manager]
FROM Employees e
JOIN Employees m
	ON e.ManagerID = m.EmployeeID
	ORDER BY m.FirstName