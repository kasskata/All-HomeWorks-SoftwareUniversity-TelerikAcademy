SELECT
	a.Title AS Title,
	t.Name AS Town
FROM Ads a
LEFT JOIN Towns t
	ON a.TownId = t.Id
ORDER BY a.Id