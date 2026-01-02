--	CTE - Common Table Expression
/*
WITH	AVGTotal (AVG_Total) AS 
	( SELECT AVG([Order Total]) AS AVG_Total
		FROM [Red30Tech].[dbo].[OnlineRetailSales$] )

SELECT * FROM [Red30Tech].[dbo].[OnlineRetailSales$], AVGTotal
WHERE [Order Total] >= AVG_Total

--	EmployeeDirectory
SELECT * from EmployeeDirectory$ WHERE [First Name] = 'Grant' AND [Last Name] = 'Nguyen'
*/
--	Write a query using recursive CTE to return 
--	Count of direct reports that Grant Nguyen has

WITH DirectReports AS (
	SELECT [EmployeeId], [First Name], [Last Name], [Manager]
	FROM [Red30Tech].[dbo].[EmployeeDirectory$]
	WHERE [EmployeeId] = 42
	UNION ALL
	SELECT e.[EmployeeId], e.[First Name], e.[Last Name], e.[Manager]
	FROM [Red30Tech].[dbo].[EmployeeDirectory$] as e
	INNER JOIN DirectReports as d ON e.[Manager] = d.[EmployeeId]
)

SELECT COUNT(*) as Direct_Reports
FROM DirectReports as d
WHERE d.[EmployeeId] != 42

--	DIRECT
SELECT count(*) 
FROM [Red30Tech].[dbo].[EmployeeDirectory$] M 
INNER JOIN [Red30Tech].[dbo].[EmployeeDirectory$] E
ON M.EmployeeId = E.Manager
WHERE M.EmployeeId= 42