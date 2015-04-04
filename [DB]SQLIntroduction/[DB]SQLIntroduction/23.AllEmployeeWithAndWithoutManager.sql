SELECT
	e.FirstName + ' ' + e.LastName AS [Employee],
	e.ManagerID AS [ManagerId],
	m.EmployeeID AS [Employee Id],
	m.FirstName + ' ' + m.LastName AS [Manager]
FROM Employees e
LEFT OUTER JOIN Employees m
	ON e.ManagerID = m.EmployeeID
ORDER BY m.FirstName + ' ' + m.LastName