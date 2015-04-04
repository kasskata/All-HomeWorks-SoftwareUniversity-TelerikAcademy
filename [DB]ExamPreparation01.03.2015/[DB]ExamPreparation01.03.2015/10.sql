SELECT
	a.Id,
	a.Title,
	a.Date,
	as1.Status
FROM Ads a
JOIN AdStatuses as1
	ON a.StatusId = as1.Id
WHERE 
	YEAR(a.Date) = YEAR((SELECT min(Date) FROM Ads))
	AND MONTH(a.Date) = MONTH((SELECT min(Date) FROM Ads))
	AND as1.Status <> 'Published'
ORDER BY a.Id
