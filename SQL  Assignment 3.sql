USE Northwind
GO

--1
SELECT city
FROM Customers
WHERE City IN
(SELECT city
FROM Employees )
group by City

--2.
-- sub-query
SELECT city
FROM Customers
WHERE City NOT IN
(SELECT city
FROM Employees )
group by City

-- Not Sub-query
SELECT distinct c.City
FROM Customers c LEFT JOIN Employees e on c.City = e.City
WHERE e.City IS NULL

--3.
SELECT  p.ProductID,SUM(od.Quantity)
FROM [Order Details] od JOIN Products p on od.ProductID = p.ProductID
GROUP BY p.ProductID

--4.
SELECT c.City, SUM(od.Quantity) [Total Products]
FROM Customers c JOIN Orders o on c.CustomerID = o.CustomerID 
JOIN [Order Details] od on o.OrderID =od.OrderID
GROUP BY c.City

--5.
--Use union
SELECT City
FROM Customers
GROUP BY City
HAVING COUNT( CustomerID) >=2
UNION
SELECT ShipCity
FROM Orders

--USE Sub-query and no union
SELECT ShipCity
FROM Orders
WHERE ShipCity IN
(SELECT City
FROM Customers
GROUP BY City
HAVING COUNT( CustomerID) > =2)
GROUP BY ShipCity

--6.
SELECT City
FROM Customers
WHERE City IN
(SELECT ShipCity
FROM Orders o JOIN [Order Details] od on o.OrderID = od.OrderID 
GROUP BY ShipCity
HAVING COUNT( ProductID) >=2
)
GROUP BY City

--7.
SELECT c.ContactName, c.City, o.ShipCity
FROM Customers c JOIN Orders o on c.CustomerID = o.CustomerID
WHERE c.City != o.ShipCity
GROUP BY c.ContactName,c.City, o.ShipCity

--8
SELECT TOP 5 p.ProductName, AVG(Quantity*p.Unitprice) [Average Price], c.City
FROM [Order Details] od JOIN Products p on od.ProductID = p.ProductID
JOIN Orders o on od.OrderID = o.OrderID
JOIN Customers c on c.CustomerID  = o.CustomerID
GROUP BY p.ProductName,c.City
ORDER BY SUM(od.Quantity) DESC 


--9.
-- Use sub-query
SELECT City
FROM Employees
WHERE City NOT IN
(SELECT ShipCity
FROM Orders)

-- Do not use sub-query
SELECT e.City
FROM Employees e LEFT JOIN Orders o ON e.City = o.ShipCity
WHERE o.ShipCity IS NULL

--10
SELECT dt1.ShipCity
FROM
(SELECT TOP 1 o.ShipCity, SUM(od.Quantity) TotalQuantity
FROM Orders o JOIN [Order Details] od on o.OrderID = od.OrderID
GROUP BY o.ShipCity
ORDER BY SUM(od.Quantity) DESC) dt1
JOIN
(SELECT TOP 1 ShipCity, sum(o.OrderID) TotalOrder
FROM  Orders o join [Order Details] od on o.OrderID = od.OrderID
group by ShipCity
ORDER BY SUM(o.OrderID) DESC)dt2 on dt1.ShipCity = dt1.ShipCity


--11.
1. Use ROW_NUMBER() Function
2. GROUP and HAVING clause count()
3. RANK function 
