SELECT
	d.Name AS DepartmentName
FROM Departments d UNION SELECT
	e.Name AS TownName
FROM Towns e