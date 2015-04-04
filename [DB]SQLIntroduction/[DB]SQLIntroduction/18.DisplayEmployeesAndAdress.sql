SELECT
	e.FirstName,
	e.LastName,
	e.AddressID AS [employee Compare ID],
	a.AddressID AS [Adress Compare ID],
	a.AddressText,
	e.DepartmentID AS [Employee Dept. Compare ID],
	d.DepartmentID AS [Department Dept. Compare ID],
	d.Name
FROM Employees e
JOIN Addresses a
	ON e.AddressID = a.AddressID
JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
ORDER BY e.FirstName