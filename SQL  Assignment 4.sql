Use Northwind
GO

--1
DROP VIEW view_product_order_jing 

CREATE VIEW view_product_order_jing 
AS
SELECT p.ProductID, SUM(od.Quantity) [Total Orders]
FROM Products p JOIN [Order Details] od on p.ProductID = od.OrderID
GROUP BY p.ProductID

--2
DROP VIEW sp_product_order_quantity_jing

CREATE PROCEDURE sp_product_order_quantity_jing
@ProductId int,
@TotalQuantities int out
AS
BEGIN
SELECT @TotalQuantities= SUM(od.Quantity)
FROM [Order Details] od
WHERE od.OrderID = @ProductId
END

--3.
DROP PROCEDURE sp_product_order_city_jing

CREATE PROCEDURE sp_product_order_city_jing
@ProductName varchar(20)
AS 
BEGIN
SELECT TOP 5 o.ShipCity, SUM(od.Quantity) [Total Quantity]
FROM [Order Details] od JOIN Orders o ON od.OrderID = o.OrderID
JOIN Products p ON od.ProductID = p.ProductID
WHERE p.ProductName = @ProductName
GROUP BY o.ShipCity
ORDER BY SUM(od.Quantity) DESC
END

--4
CREATE TABLE people_jing
(Id int Primary Key,
PName varchar(20),
City Varchar(20))

CREATE TABLE city_jing
(Id int Primary Key,
City Varchar(20))

INSERT INTO people_jing VALUES(1,'Aaron Rodgers', 2)
INSERT INTO people_jing VALUES(2,'Russell Wilson',1)
INSERT INTO people_jing VALUES(3,'Jody Nelson',2)

INSERT INTO city_jing VALUES(1,'Seattle')
INSERT INTO city_jing VALUES(2,'Green Bay')

SELECT *
FROM people_jing

SELECT *
FROM city_jing

INSERT INTO city_jing VALUES(3,'Madison')

UPDATE people_jing 
SET City = (SELECT Id
FROM  city_jing
WHERE City = 'Madison')
WHERE City IN
(SELECT Id
FROM city_jing
WHERE City = 'Seattle'
)

DELETE city_jing
WHERE City = 'Seattle'

CREATE VIEW Packer_jing
AS
SELECT PName
FROM people_jing
WHERE City = 'Green Bay'

DROP TABLE people_jing
DROP TABLE city_jing	
DROP VIEW Packer_jing

--5.
-- I have a question here!!
-- I have to create TABLE birthday_employees_jing before PROCEDURE
-- I cannot create that table in procedure
DROP TABLE birthday_employees_jing
DROP PROCEDURE sp_birthday_employees_jing

SELECT DATA_TYPE 
FROM INFORMATION_SCHEMA.COLUMNS
WHERE 
     TABLE_NAME   = 'Employees' AND 
     COLUMN_NAME  = 'BirthDate'

CREATE PROCEDURE sp_birthday_employees_jing
AS
BEGIN
CREATE TABLE birthday_employees_jing
(Id int PRIMARY KEY,
EName varchar(20) NOT NULL,
Birthday datetime NOT NULL
);
INSERT birthday_employees_jing
SELECT EmployeeID, FirstName+ ' ' +LastName [Employee Name], BirthDate 
FROM Employees
WHERE MONTH(BirthDate) = 2
END

SELECT * FROM Employees
SELECT * FROM Employees WHERE MONTH(BirthDate) = 2
SELECT * FROM birthday_employees_jing

DROP TABLE birthday_employees_jing

--6
-- 1.UNION
-- If we get number same as the the sum of the rows of the two tables
-- But this way only care about differences in the attributes

-- 2.EXCEPT
-- return no rows: same
-- renturn rows: not same

-- 3.MINUS 
-- return no rows: same


