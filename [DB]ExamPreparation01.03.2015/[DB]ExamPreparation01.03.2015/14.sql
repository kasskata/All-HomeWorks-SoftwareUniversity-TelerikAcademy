SELECT
	COUNT(a.Id) AS AdsCount,
	(CASE 
    	WHEN t.Name IS NOT NULL THEN t.Name ELSE '(no town)'
    END) AS Town
FROM Ads a
FULL JOIN Towns t ON a.TownId = t.Id
GROUP BY t.Name
HAVING COUNT(a.id) BETWEEN 2 AND 3
ORDER BY t.Name