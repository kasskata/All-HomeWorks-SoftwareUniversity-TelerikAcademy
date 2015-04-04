BEGIN TRAN
	CREATE TABLE Countries (
		Id INT IDENTITY (1, 1) NOT NULL PRIMARY KEY,
		Name NVARCHAR(MAX) NULL
	)
	ALTER TABLE Towns ADD CountryId INT FOREIGN KEY REFERENCES Countries (Id)
COMMIT

INSERT INTO Countries (Name)
	VALUES ('Bulgaria'), ('Germany'), ('France')
UPDATE Towns
SET CountryId = (SELECT
	Id
FROM Countries
WHERE Name = 'Bulgaria')
INSERT INTO Towns
	VALUES ('Munich', (SELECT Id FROM Countries WHERE Name = 'Germany')),
	('Frankfurt', (SELECT Id FROM Countries WHERE Name = 'Germany')),
	('Berlin', (SELECT Id FROM Countries WHERE Name = 'Germany')),
	('Hamburg', (SELECT Id FROM Countries WHERE Name = 'Germany')),
	('Paris', (SELECT Id FROM Countries WHERE Name = 'France')),
	('Lyon', (SELECT Id FROM Countries WHERE Name = 'France')),
	('Nantes', (SELECT Id FROM Countries WHERE Name = 'France'))

BEGIN TRAN
	UPDATE Ads
	SET TownId = 29
	WHERE DATENAME(dw, Ads.Date) = 'Friday'

	SELECT
		a.Date,
		a.TownId
	FROM Ads a
	WHERE DATENAME(dw, a.Date) = 'Friday'

COMMIT TRAN

SELECT
	t.Id
FROM Towns t
WHERE t.Name = 'Hamburg'

BEGIN TRAN
	UPDATE Ads
	SET TownId = 28
	WHERE DATENAME(dw, Ads.Date) = 'Thursday'

	SELECT
		a.Date,
		a.TownId
	FROM Ads a
	WHERE DATENAME(dw, a.Date) = 'Thursday'

COMMIT TRAN

SELECT
		a.Id
FROM Ads a
JOIN AspNetUsers u ON a.OwnerId = u.Id
JOIN AspNetUserRoles ur ON ur.UserId = u.Id
JOIN AspNetRoles r ON r.Id = ur.RoleId
WHERE u.Name = 'nakov'

BEGIN TRAN
DELETE FROM Ads
WHERE Ads.Id IN (
	SELECT
			a.Id
		FROM Ads a
		JOIN AspNetUsers u ON a.OwnerId = u.Id
		JOIN AspNetUserRoles ur ON ur.UserId = u.Id
		JOIN AspNetRoles r ON r.Id = ur.RoleId
		WHERE r.Name = 'Partner'
)
COMMIT TRAN
--6.	Add a new add holding the following information: 
--Title="Free Book", 
--Text="Free C# Book", 
--Date={current date and time}, 
--Owner="nakov", 
--Status="Waiting Approval".


INSERT INTO Ads (Title, Text, ImageDataURL, OwnerId, CategoryId, TownId, Date, StatusId)
	VALUES (N'Free Book', N'Free C# Book', N'', N'39b7333d-664b-428d-9e11-4cde699d5e5e',NULL, NULL, GETDATE(), 2);
GO

SELECT 
	t.Name AS Town,
	c.Name AS Country,
	COUNT(a.Id) AS AdsCount
FROM Ads a
	FULL JOIN Towns t ON a.TownId = t.Id
	FULL JOIN Countries c ON t.CountryId = c.Id
GROUP BY t.Name, c.Name
ORDER BY t.Name, c.Name
