IF OBJECT_ID('AllAds') IS NOT NULL
	DROP VIEW AllAds
GO
CREATE VIEW AllAds
AS
SELECT TOP 100 PERCENT
	a.Id,
	a.Title,
	u.UserName AS Author,
	a.Date,
	t.Name AS Town,
	c.Name AS Category,
	as1.Status
FROM Ads a
FULL JOIN Towns t
	ON a.TownId = t.Id
FULL JOIN Categories c
	ON a.CategoryId = c.Id
FULL JOIN AdStatuses as1
	ON a.StatusId = as1.Id
FULL JOIN AspNetUsers u
	ON a.OwnerId = u.Id
ORDER BY a.Id
GO
SELECT
	*
FROM AllAds
GO

--2--------------------------------------------------------------------------------
IF OBJECT_ID('udf_ListUsersAds') IS NOT NULL
	DROP FUNCTION udf_ListUsersAds
GO

CREATE FUNCTION udf_ListUsersAds ()
RETURNS @ads TABLE (
	UserName NVARCHAR(MAX),
	AdDates NVARCHAR(MAX)
)
AS
BEGIN

	DECLARE	@user VARCHAR(MAX),
			@datesString NVARCHAR(MAX)

	DECLARE KUR CURSOR -- Declare cursor
	LOCAL SCROLL STATIC FOR

	SELECT
		a.Author
	FROM AllAds a
	GROUP BY a.Author
	ORDER BY a.Author DESC



	OPEN KUR -- open the cursor
	FETCH NEXT FROM KUR
	INTO @user

	WHILE @@fetch_status = 0
	BEGIN

		SET @datesString = (SELECT
			STUFF((SELECT
				N'; ' + CONVERT(NVARCHAR(8), aa.Date, 112)
			FROM AllAds aa
			WHERE @user = aa.Author
			ORDER BY aa.Date
			FOR XML PATH (''), TYPE)
			.value('text()[1]', 'nvarchar(max)'), 1, 2, N''))
		IF @user IS NOT NULL
		BEGIN
			IF @datesString IS NOT NULL
			BEGIN
				INSERT INTO @ads (UserName, AdDates)
					VALUES (@user, @datesString);
			END
			ELSE
				INSERT INTO @ads (UserName, AdDates)
					VALUES (@user, N'NULL');
		END

		FETCH NEXT FROM KUR INTO @user
	END
	CLOSE KUR -- close the cursor
	DEALLOCATE KUR -- Deallocate the cursor
	RETURN
END
GO

SELECT
	*
FROM dbo.udf_ListUsersAds()