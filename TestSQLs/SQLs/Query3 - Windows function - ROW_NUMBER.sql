--	Write a query using ROW_NUMBER to return each customers most recent order

--	SELECT * FROM [Red30Tech].[dbo].[OnlineRetailSales$]
--	SELECT distinct CustName FROM [Red30Tech].[dbo].[OnlineRetailSales$] ORDER BY CustName

SELECT CUSTNAME, Count(Distinct OrderNum)
FROM [Red30Tech].[dbo].[OnlineRetailSales$]
GROUP BY CUSTNAME

SELECT [OrderNum], [OrderDate], [CustName], [ProdName], [Quantity],
ROW_NUMBER() OVER( PARTITION BY [CustName] ORDER BY OrderDate DESC) as ROW_NUM
FROM [Red30Tech].[dbo].[OnlineRetailSales$]

--	Add CTE or Subquery
WITH ROW_NUMBERS AS (
SELECT [OrderNum], [OrderDate], [CustName], [ProdName], [Quantity],
ROW_NUMBER() OVER( PARTITION BY [CustName] ORDER BY OrderDate DESC) as ROW_NUM
FROM [Red30Tech].[dbo].[OnlineRetailSales$]
)
SELECT * FROM ROW_NUMBERS WHERE ROW_NUM = 2

--	Add CTE or Subquery for 3 orders with highest Order Totals from each ProdCategory purchased by Boehm Inc.
WITH ROW_NUMBERS AS (
SELECT [OrderNum], [OrderDate], [CustName], [ProdCategory], [ProdName], [Order Total],
ROW_NUMBER() OVER( PARTITION BY [ProdCategory] ORDER BY [Order Total] DESC) as ROW_NUM
FROM [Red30Tech].[dbo].[OnlineRetailSales$]
WHERE [CustName] = 'Boehm Inc.'
)
SELECT * FROM ROW_NUMBERS WHERE ROW_NUM <= 3