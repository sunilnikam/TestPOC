--	Write a query using Rank and Dense Rank
SELECT * FROM [Red30Tech].[dbo].[EmployeeDirectory$]

SELECT *, 
RANK() OVER (ORDER BY [Last Name]) as RANK_,
DENSE_RANK() OVER (ORDER BY [Last Name]) as DENSE_RANK_
FROM [Red30Tech].[dbo].[EmployeeDirectory$]

--	SELECT * FROM [Red30Tech].[dbo].[ConventionAttendees$]
--	Write a query using Rank() or Dense_Rank() that pulls all registration information for the 
--	first three people that registered for the conference
WITH RANKS AS (
SELECT *,
RANK() OVER (Partition BY STATE ORDER BY [Registration Date]) AS RANK_,
DENSE_RANK() OVER (Partition BY STATE ORDER BY [Registration Date]) AS DENSE_RANK_
FROM [Red30Tech].[dbo].[ConventionAttendees$]
)
SELECT * FROM RANKS 

WITH RANKS AS (
SELECT *,
DENSE_RANK() OVER (Partition BY STATE ORDER BY [Registration Date]) AS DENSE_RANK_
FROM [Red30Tech].[dbo].[ConventionAttendees$]
)

SELECT * FROM RANKS WHERE DENSE_RANK_ IN (1,2,3)

WITH RANKS AS (
SELECT *,
RANK() OVER (Partition BY STATE ORDER BY [Registration Date]) AS RANK_
FROM [Red30Tech].[dbo].[ConventionAttendees$]
)

SELECT * FROM RANKS WHERE RANK_ IN (1,2,3)