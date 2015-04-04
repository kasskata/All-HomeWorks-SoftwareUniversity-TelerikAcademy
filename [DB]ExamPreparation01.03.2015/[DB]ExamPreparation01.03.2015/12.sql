SELECT 
	t.Name AS [Town Name], 
	as1.Status,
	COUNT(a.Title) AS [Count]
FROM Ads a 
	 JOIN Towns t ON a.TownId = t.Id
	 JOIN AdStatuses as1 ON a.StatusId = as1.Id
	GROUP BY as1.Status, t.Name
ORDER BY t.Name, as1.Status