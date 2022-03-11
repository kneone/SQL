USE AdventureWorks2019
GO

--1 
SELECT COUNT(DISTINCT ProductID)
FROM Production.Product
-- 504 products

--2
SELECT COUNT(ProductID)
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL

--3
SELECT ProductSubcategoryID, COUNT(ProductID) AS CountedProducts
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL
GROUP BY ProductSubcategoryID

--4
SELECT COUNT(ProductID)
FROM Production.Product
WHERE ProductSubcategoryID IS NULL

--5. 
SELECT SUM(Quantity)
FROM Production.ProductInventory

--6.
SELECT ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID
HAVING SUM(Quantity) < 100

--7.
SELECT Shelf,ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY Shelf,ProductID
HAVING SUM(Quantity) < 100

--8
SELECT ProductID, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WHERE LocationID = 10
GROUP BY ProductID

--9
SELECT ProductID, Shelf,AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
GROUP BY ProductID,Shelf

--10
SELECT ProductID, Shelf,AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WHERE Shelf NOT IN ('N/A')
GROUP BY ProductID,Shelf

--11
SELECT Color, Class, COUNT(ProductID) TheCount, AVG(ListPrice) AvgPrice
FROM Production.Product
WHERE Color IS NOT NULL AND Class IS NOT NULL
GROUP BY Color, Class

--12
SELECT pc.Name Country, ps.Name Provinece
FROM person.CountryRegion pc JOIN person.StateProvince ps on pc.CountryRegionCode = ps.CountryRegionCode

--13
SELECT pc.Name Country, ps.Name Provinece
FROM person.CountryRegion pc JOIN person.StateProvince ps on pc.CountryRegionCode = ps.CountryRegionCode
WHERE pc.Name IN ('Germany','Canada')


USE Northwind 
GO
--14
SELECT p.ProductName
FROM  [Order Details] od join Orders o on od.OrderID = o.OrderID 
JOIN Products p on od.ProductID = p.ProductID
WHERE o.OrderDate >= '1997-03-10'
GROUP BY p.ProductName
HAVING COUNT(od.ProductID) >= 1
order by  p.ProductName


--15
SELECT TOP 5 ShipPostalCode [Zip Code], COUNT(ShipPostalCode) NumOfSolds
FROM Orders
GROUP BY ShipPostalCode
HAVING ShipPostalCode IS NOT NULL
ORDER BY COUNT(ShipPostalCode) DESC

--16
SELECT TOP 5 ShipPostalCode [Zip Code], COUNT(ShipPostalCode) NumOfSolds
FROM Orders 
WHERE OrderDate >= '1997-03-10'
GROUP BY ShipPostalCode
HAVING ShipPostalCode IS NOT NULL
ORDER BY COUNT(ShipPostalCode) DESC

--17
SELECT c.City, COUNT(c.ContactName) NumOfCustomers
FROM Customers c
GROUP BY c.City

--18
SELECT c.City, COUNT(c.ContactName) NumOfCustomers
FROM Customers c
GROUP BY c.City
HAVING COUNT(c.ContactName) >2

--19
SELECT c.ContactName
FROM Orders o JOIN Customers c on o.CustomerID = c.CustomerID
WHERE o.OrderDate > '1998-01-01'
GROUP BY c.ContactName

--20
SELECT c.ContactName, MAX(o.OrderDate)
FROM Orders o JOIN Customers c on o.CustomerID = c.CustomerID 
GROUP BY c.ContactName

--21 check
-- Not Sure about the meaning of "Count of products", therefore I used two ways
-- The first way: "Count of products" means the count of unique products.

SELECT c.ContactName, COUNT(od.Quantity)
FROM Orders o JOIN Customers c on o.CustomerID = c.CustomerID 
JOIN [Order Details] od on od.OrderID = o.OrderID
GROUP BY c.ContactName
ORDER BY COUNT(od.Quantity) DESC

-- The second way: "Count of products" means the total quantity of all products.
SELECT c.ContactName, SUM(od.Quantity)
FROM Orders o JOIN Customers c on o.CustomerID = c.CustomerID 
JOIN [Order Details] od on od.OrderID = o.OrderID
GROUP BY c.ContactName
ORDER BY SUM(od.Quantity) DESC


--22
-- Not Sure about the meaning of "Count of products", therefore I used two ways
-- The first way: "Count of products" means the count of unique products.
SELECT c.CustomerID
FROM Orders o JOIN Customers c on o.CustomerID = c.CustomerID 
JOIN [Order Details] od on od.OrderID = o.OrderID
GROUP BY c.CustomerID
HAVING COUNT(od.Quantity) > 100

-- The second way: "Count of products" means the total quantity of all products.
SELECT c.CustomerID
FROM Orders o JOIN Customers c on o.CustomerID = c.CustomerID 
JOIN [Order Details] od on od.OrderID = o.OrderID
GROUP BY c.CustomerID
HAVING SUM(od.Quantity) > 100

--23
SELECT s.CompanyName [Supplier Company Name], sh.CompanyName [Shipping Company Name]
FROM Suppliers s CROSS JOIN Shippers sh
order by s.CompanyName

--24
SELECT o.OrderDate, p.ProductName
FROM [Order Details] od JOIN Orders o on od.OrderID = o.OrderID 
JOIN Products p on od.ProductID = p.ProductID
GROUP BY o.OrderDate, p.ProductName

--25
SELECT e1.Title,e1.FirstName + ' ' + e1.LastName [Frist Employee], e2.FirstName + ' ' + e2.LastName [Second Employee]
FROM Employees e1 JOIN Employees e2 on e1.Title = e2.Title
Where e1.FirstName + ' ' + e1.LastName != e2.FirstName + ' ' + e2.LastName

--26
SELECT e1.FirstName +' '+ e1.LastName AS Managers
FROM Employees e1
INNER JOIN Employees e2
ON e1.EmployeeID = e2.ReportsTo
GROUP BY e1.FirstName +' '+ e1.LastName
HAVING COUNT(e2.ReportsTo) > 2

--27
SELECT c.City,c.CompanyName [NAME], c.ContactName [Contact Name], 'Customer' Type
FROM Customers c
UNION
SELECT s.City,s.CompanyName [NAME], s.ContactName [Contact Name], 'Supplier' Type
FROM Suppliers s

