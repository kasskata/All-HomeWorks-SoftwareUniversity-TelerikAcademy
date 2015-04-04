SELECT
	as1.Status AS [Status],
	COUNT(a.Id) AS [Count]
FROM Ads a
JOIN AdStatuses as1
	ON a.StatusId = as1.Id
GROUP BY as1.Status
ORDER BY as1.Status