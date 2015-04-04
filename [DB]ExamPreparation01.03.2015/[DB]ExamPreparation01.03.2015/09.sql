SELECT TOP 10
	a.Title,
	a.Date,
	as1.Status
FROM Ads a JOIN AdStatuses as1 ON a.StatusId = as1.Id
ORDER BY a.Date DESC