SELECT
DISTINCT
	e.FirstName,
	e.LastName,
	e.JobTitle,
	d.Name,
	e.Salary
FROM Employees e
JOIN Departments d
	ON e.JobTitle = 'Sales Representative'
	AND e.DepartmentID = d.DepartmentID
ORDER BY e.FirstName, e.LastName, e.Salary
