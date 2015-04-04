SELECT
	a.Id,
	a.Title,
	a.Text,
	a.ImageDataURL,
	a.OwnerId,
	a.CategoryId,
	a.TownId,
	a.Date,
	a.StatusId
FROM Ads a
WHERE a.TownId IS NULL OR a.CategoryId IS NULL OR a.ImageDataURL IS NULL
ORDER BY a.Id