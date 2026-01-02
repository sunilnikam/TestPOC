--	In stock of items that have less than the avarage amount of products left in stock

--	Direct
select prodcategory, prodnumber, prodname, [in stock] from dbo.Inventory$ i
where i.[in stock] < 
	( select avg([in stock]) from dbo.inventory$ i2)

-- WITH CTE
WITH LOWSTOCK(STOCK) AS (
	SELECT AVG([In Stock]) FROM [Red30Tech].[dbo].Inventory$ )

SELECT [ProdCategory], [ProdNumber], [ProdName], [In Stock]
FROM [Red30Tech].[dbo].Inventory$, LOWSTOCK
WHERE [In Stock] < STOCK

--	Order Total > Avg total
SELECT * FROM [Red30Tech].[dbo].[OnlineRetailSales$]
WHERE [Order Total] >= 
				( SELECT AVG([Order Total]) FROM [Red30Tech].[dbo].[OnlineRetailSales$])
--	WITH CTE
