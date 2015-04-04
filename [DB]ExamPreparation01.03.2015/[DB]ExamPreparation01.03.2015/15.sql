SELECT
	a.Date AS FirstDate,
	a1.Date AS SecondDate
FROM	Ads a,
		Ads a1
WHERE a.Date < a1.Date
AND a1.Date <= DATEADD(HOUR, 12, a.Date)
ORDER BY a.Date, a1.Date