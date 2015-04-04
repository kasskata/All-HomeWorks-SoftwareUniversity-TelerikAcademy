SELECT
	e.FirstName,
	e.LastName,
	e.Salary
FROM Employees e
WHERE e.Salary BETWEEN 20000 AND 30000
ORDER BY e.Salary