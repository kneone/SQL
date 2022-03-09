USE AdventureWorks2019
GO

--1.Write a query that retrieves the columns ProductID, Name, 
-- Color and ListPrice from the Production.Product table, with no filter. 
SELECT pp.ProductID, pp.Name, pp.Color, pp.ListPrice
FROM Production.Product pp

--2.Write a query that retrieves the columns ProductID, Name, Color and ListPrice 
-- from the Production.Product table, excludes the rows that ListPrice is 0.
SELECT pp.ProductID, pp.Name, pp.Color, pp.ListPrice
FROM Production.Product pp
WHERE pp.ListPrice != 0

--3 Write a query that retrieves the columns ProductID, Name, Color and ListPrice 
-- from the Production.Product table, the rows that are NULL for the Color column.
SELECT pp.ProductID, pp.Name, pp.Color, pp.ListPrice
FROM Production.Product pp
WHERE pp.Color IS NULL

--4.Write a query that retrieves the columns ProductID, Name, Color and ListPrice 
-- from the Production.Product table, the rows that are not NULL for the Color column.
SELECT pp.ProductID, pp.Name, pp.Color, pp.ListPrice
FROM Production.Product pp
WHERE pp.Color IS NOT NULL 

--5.Write a query that retrieves the columns ProductID, Name, Color and ListPrice 
-- from the Production.Product table, the rows that are not NULL for the column Color, 
-- and the column ListPrice has a value greater than zero.
SELECT pp.ProductID, pp.Name, pp.Color, pp.ListPrice
FROM Production.Product pp
WHERE pp.Color IS NOT NULL AND pp.ListPrice > 0

--6.Write a query that concatenates the columns Name and Color from the Production.
-- Product table by excluding the rows that are null for color.
SELECT pp.Name +' '+ pp.Color as NameColor
FROM Production.Product pp
WHERE pp.Color IS NOT NULL 

--7.Write a query that generates the following result set  from Production.Product:
-- NAME: LL Crankarm  --  COLOR: Black
-- NAME: ML Crankarm  --  COLOR: Black
-- NAME: HL Crankarm  --  COLOR: Black
-- NAME: Chainring Bolts  --  COLOR: Silver
-- NAME: Chainring Nut  --  COLOR: Silver
-- NAME: Chainring  --  COLOR: Black
SELECT 'NAME: ' + pp.Name + ' -- COLOR: ' + pp.Color 
FROM Production.Product pp 
WHERE pp.Name IS NOT NULL AND pp.Color IS NOT NULL

--8.Write a query to retrieve the to the columns ProductID and Name 
-- from the Production.Product table filtered by ProductID from 400 to 500
SELECT pp.ProductID, pp.Name
FROM Production.Product pp
WHERE pp.ProductID BETWEEN 400 and 500

--9.Write a query to retrieve the to the columns  ProductID, 
-- Name and color from the Production.Product table restricted to the colors black and blue
SELECT pp.ProductID, pp.Name, pp.Color
FROM Production.Product pp
WHERE pp.Color IN ('black', 'blue')

--10.Write a query to get a result set on products that begins with the letter S. 
SELECT pp.Name
FROM Production.Product pp
WHERE pp.Name LIKE 'S%'

--11.Write a query that retrieves the columns Name and ListPrice from the Production.
-- Product table. Your result set should look something like the following. Order the result set by the Name column. 
SELECT pp.Name, pp.ListPrice
FROM Production.Product pp
ORDER BY pp.Name

--12.Write a query that retrieves the columns Name and ListPrice from the Production.Product table. 
-- Your result set should look something like the following. Order the result set by the Name column. 
-- The products name should start with either 'A' or 'S'
SELECT pp.Name, pp.ListPrice
FROM Production.Product pp
WHERE pp.Name LIKE '[AS]%'
ORDER BY pp.Name

--13.Write a query so you retrieve rows that have a Name that begins with the letters SPO, 
-- but is then not followed by the letter K. After this zero or more letters can exists. 
-- Order the result set by the Name column.
SELECT pp.Name
FROM Production.Product pp
--WHERE pp.Name LIKE 'SPO%' AND pp.Name NOT LIKE '___k%'
WHERE pp.Name LIKE 'SPO[^k]%'
ORDER BY pp.Name


--14.Write a query that retrieves unique colors from the table Production.
-- Product. Order the results  in descending  manner
SELECT DISTINCT pp.Color
FROM Production.Product pp
ORDER BY pp.Color DESC

--15.Write a query that retrieves the unique combination of columns ProductSubcategoryID 
-- and Color from the Production.Product table. Format and sort so the result set accordingly to the following. 
-- We do not want any rows that are NULL.in any of the two columns in the result.
SELECT DISTINCT pp.ProductSubcategoryID, pp.Color
FROM Production.Product pp
WHERE pp.ProductSubcategoryID IS NOT NULL AND pp.Color IS NOT NULL
