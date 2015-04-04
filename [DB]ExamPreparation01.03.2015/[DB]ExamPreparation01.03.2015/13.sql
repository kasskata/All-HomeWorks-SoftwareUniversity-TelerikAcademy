SELECT
	u.UserName AS UserName,
	COUNT(a.Id) AS AdsCount,
	(CASE
		WHEN u.UserName IN (SELECT
				u.UserName
			FROM AspNetUsers u
			JOIN AspNetUserRoles anur
				ON u.Id = anur.UserId
			JOIN AspNetRoles anr
				ON anur.RoleId = anr.Id
			WHERE anr.Name = 'Administrator') THEN 'yes'
		ELSE 'no'
	END) AS IsAdministrator

FROM AspNetUsers u
LEFT JOIN Ads a
	ON u.Id = a.OwnerId
GROUP BY u.UserName
ORDER BY u.UserName