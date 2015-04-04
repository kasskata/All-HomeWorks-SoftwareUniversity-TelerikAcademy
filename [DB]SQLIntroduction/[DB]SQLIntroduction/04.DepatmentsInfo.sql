SELECT m.FirstName as [Manager=>], d.Name as [Department Name],d.DepartmentID
FROM Departments d 
JOIN Employees m
on m.ManagerID = d.ManagerID