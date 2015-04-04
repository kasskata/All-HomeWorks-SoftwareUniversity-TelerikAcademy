SELECT
	e.FirstName,
	e.LastName,
	e.Salary
FROM Employees e
WHERE e.Salary >= 50000
order BY e.Salary DESC