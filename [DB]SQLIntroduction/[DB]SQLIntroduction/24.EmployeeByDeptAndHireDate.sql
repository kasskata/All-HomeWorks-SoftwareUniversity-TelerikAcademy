SELECT
	e.FirstName + ' ' + e.LastName AS Employee,
	e.DepartmentID AS [Employee DeptID],
	d.DepartmentID AS [Adress DeptID],
	d.Name,
	e.HireDate
FROM Employees e
JOIN Departments d
	ON (1995 <= YEAR(e.HireDate)
	AND YEAR(e.HireDate) <= 2005)
	AND ((e.DepartmentID = d.DepartmentID
	AND d.Name = 'Sales')
	OR (e.DepartmentID = d.DepartmentID
	AND d.Name = 'Finance'))
ORDER BY e.HireDate