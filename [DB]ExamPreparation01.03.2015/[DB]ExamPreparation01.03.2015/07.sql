SELECT
	a.Title AS Title,
	c.Name AS CategoryName,
	t.Name AS TownName,
	as1.Status AS [Status]
FROM Ads a
JOIN Categories c
	ON a.CategoryId = c.Id
JOIN Towns t
	ON a.TownId = t.Id
JOIN AdStatuses as1
	ON a.StatusId = as1.Id
WHERE as1.Status = 'Published'
AND (t.Name = 'Sofia'
OR t.Name = 'Blagoevgrad'
OR t.Name = 'Stara Zagora')

ORDER BY a.Title
--, Blagoevgrad or Stara Zagora