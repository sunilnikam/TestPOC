
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

--------------------------------------------------------------------------------
--	Add CTE or Subquery for 3 orders with highest Order Totals from each ProdCategory purchased by Boehm Inc.
WITH ROW_NUMBERS AS (
SELECT [OrderNum], [OrderDate], [CustName], [ProdCategory], [ProdName], [Order Total],
ROW_NUMBER() OVER( PARTITION BY [ProdCategory] ORDER BY [Order Total] DESC) as ROW_NUM

FROM [Red30Tech].[dbo].[OnlineRetailSales$]
WHERE [CustName] = 'Boehm Inc.'
)
SELECT * FROM ROW_NUMBERS WHERE ROW_NUM <= 3

LAG([Session Name], 1) OVER (Order by [Start Date] ASC) AS PreviousSession,
LEAD([Quantity_By_Day], 1) OVER (Order By [OrderDate] ASC) as LastDateQuantity_1,

Serial number	RANK() OVER (Partition BY STATE ORDER BY [Registration Date]) AS RANK_,
Next grouped	DENSE_RANK() OVER (Partition BY STATE ORDER BY [Registration Date]) AS DENSE_RANK_