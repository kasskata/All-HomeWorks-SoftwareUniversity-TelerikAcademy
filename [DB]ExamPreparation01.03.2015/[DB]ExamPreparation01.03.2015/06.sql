SELECT
	a.Title AS Title,
	c.Name AS CategoryName,
	t.Name AS TownName,
	as1.Status as [Status]
FROM Ads a
LEFT JOIN Categories c
	ON a.CategoryId = c.Id
LEFT JOIN Towns t
	ON a.TownId = t.Id
LEFT JOIN AdStatuses as1
	ON a.StatusId = as1.Id
ORDER BY a.Id