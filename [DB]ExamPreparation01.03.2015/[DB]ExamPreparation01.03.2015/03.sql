SELECT
	a.Title AS Title, 
	a.Date AS Date,
	(CASE 
    	WHEN a.ImageDataURL IS NOT NULL THEN 'yes'
    	WHEN a.ImageDataURL IS NULL THEN 'no'
    END) AS [Has Image]
FROM Ads a
ORDER BY a.Id