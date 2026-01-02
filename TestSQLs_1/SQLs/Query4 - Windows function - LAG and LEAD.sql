--	Write a query using ROW_NUMBER to return each customers most recent order

--	SELECT * FROM [Red30Tech].[dbo].[SessionInfo$]
--	 USE LAG() and LEAD() to get session name and start time of the previous and next session

SELECT [Start Date], [End Date], [Session Name], 

LAG([Session Name], 1) OVER (Order by [Start Date] ASC) AS PreviousSession,
LAG([Start Date], 1) OVER (Order by [Start Date] ASC) AS PreviousSessionStartTime,

LEAD([Session Name], 1) OVER (Order by [Start Date] ASC) AS NextSession,
LEAD([Start Date], 1) OVER (Order by [Start Date] ASC) AS NextSessionStartTime

FROM [Red30Tech].[dbo].[SessionInfo$]

--	Write a query using LAG() or LEAD for each drone order from the OnlintRetailSales table
--	Order Date, Quantity, Quantities from the last five Order Dates
--	SELECT * FROM [Red30Tech].[dbo].[OnlineRetailSales$]

WITH ORDER_BY_DAYS AS (
			SELECT [OrderDate], SUM([Quantity]) Quantity_By_Day
			FROM [Red30Tech].[dbo].[OnlineRetailSales$]
			WHERE [ProdCategory] = 'Drones'
			GROUP BY ORDERDATE
)
SELECT ORDERDate, Quantity_By_Day,
LAG([Quantity_By_Day], 1) OVER (Order By [OrderDate] ASC) as LastDateQuantity_1,
LAG([Quantity_By_Day], 2) OVER (Order By [OrderDate] ASC) as LastDateQuantity_2,
LAG([Quantity_By_Day], 3) OVER (Order By [OrderDate] ASC) as LastDateQuantity_3,
LAG([Quantity_By_Day], 4) OVER (Order By [OrderDate] ASC) as LastDateQuantity_4,
LAG([Quantity_By_Day], 5) OVER (Order By [OrderDate] ASC) as LastDateQuantity_5
FROM ORDER_BY_DAYS
;
WITH ORDER_BY_DAYS AS (
			SELECT [OrderDate], SUM([Quantity]) Quantity_By_Day
			FROM [Red30Tech].[dbo].[OnlineRetailSales$]
			WHERE [ProdCategory] = 'Drones'
			GROUP BY ORDERDATE
)
SELECT ORDERDate, Quantity_By_Day,
LEAD([Quantity_By_Day], 1) OVER (Order By [OrderDate] ASC) as LastDateQuantity_1,
LEAD([Quantity_By_Day], 2) OVER (Order By [OrderDate] ASC) as LastDateQuantity_2,
LEAD([Quantity_By_Day], 3) OVER (Order By [OrderDate] ASC) as LastDateQuantity_3,
LEAD([Quantity_By_Day], 4) OVER (Order By [OrderDate] ASC) as LastDateQuantity_4,
LEAD([Quantity_By_Day], 5) OVER (Order By [OrderDate] ASC) as LastDateQuantity_5
FROM ORDER_BY_DAYS
;