USE Northwind
GO

-- 1.
SELECT DISTINCT c.City
FROM dbo.Customers c
JOIN dbo.Employees e ON c.City = e.City

-- 2a.
SELECT DISTINCT City 
FROM dbo.Customers
WHERE City NOT IN (
    SELECT City FROM dbo.Employees
    )

-- 2b.
SELECT DISTINCT c.City 
FROM dbo.Customers c
LEFT JOIN dbo.Employees e ON c.City = e.City
WHERE e.City IS NULL

-- 3.
SELECT p.ProductID, p.ProductName, OrderQuantity.TotalQuantities
FROM dbo.Products p
JOIN (
    SELECT od.ProductID, SUM(od.Quantity) AS TotalQuantities
    FROM dbo.[Order Details] od
    JOIN dbo.Orders o ON od.OrderID = o.OrderID
    GROUP BY od.ProductID
    ) OrderQuantity
ON p.ProductID = OrderQuantity.ProductID

-- 4.
SELECT c.City, SUM(q.Quantity) AS QuantityPerCity
FROM dbo.Customers c
JOIN (
    SELECT o.CustomerID, od.Quantity
    FROM dbo.Orders o
    JOIN dbo.[Order Details] od ON o.OrderID = od.OrderID
) q ON c.CustomerID = q.CustomerID
GROUP BY c.City

-- 5a.
SELECT c.City 
FROM dbo.Customers c
EXCEPT
SELECT c.City 
FROM dbo.Customers c
GROUP BY c.City
HAVING COUNT(*) = 1
SELECT c.City 
FROM dbo.Customers c
GROUP BY c.City
HAVING COUNT(*) = 0

-- 5b.
SELECT c.City
FROM dbo.Customers c
GROUP BY c.City
HAVING COUNT(*) >= 2

-- 6.
SELECT c.City
FROM dbo.Customers c
JOIN dbo.Orders o ON c.CustomerID = o.CustomerID
JOIN dbo.[Order Details] od ON od.OrderID = o.OrderID
GROUP BY c.City
HAVING COUNT(DISTINCT od.ProductID) >= 2

-- 7.
SELECT DISTINCT c.CustomerID, c.ContactName, c.City, o.ShipCity
FROM dbo.Customers c
JOIN dbo.Orders o ON c.CustomerID = o.CustomerID
WHERE c.City != o.ShipCity

-- 8.
SELECT Top5.ProductID, Top5.AvgPrice, c.City
FROM [Order Details] od
JOIN (
    SELECT TOP 5 p.ProductID, SUM(od.Quantity) AS QuanPerProduct, AVG(p.UnitPrice) AS AvgPrice
    FROM Products p
    JOIN [Order Details] od ON od.ProductID=p.ProductID
    JOIN Orders o ON od.OrderID=o.OrderID
    GROUP BY p.ProductID
    ORDER BY QuanPerProduct DESC
) Top5 ON Top5.ProductID = od.ProductID
JOIN Orders o ON o.OrderID = od.OrderID
JOIN Customers c ON o.CustomerID = c.CustomerID

-- 9a.
SELECT DISTINCT City
FROM Employees 
WHERE City IN (
    SELECT DISTINCT ShipCity
    FROM Orders
    WHERE ShipCity IS NULL
)

-- 9b.
SELECT DISTINCT City
FROM Employees
WHERE City IS NOT NULL
EXCEPT (
    SELECT DISTINCT ShipCity
    FROM Orders
    WHERE ShipCity IS NOT NULL
)

-- 10.
SELECT (
    SELECT TOP 1 e.City
    FROM Orders o
    JOIN [Order Details] od ON o.OrderID=od.OrderID
    JOIN Employees e ON e.EmployeeID = o.EmployeeID
    GROUP BY e.EmployeeID, e.City
    ORDER BY COUNT(*) DESC
) AS MostOdersCity, (
    SELECT TOP 1 e.City
    FROM Orders o
    JOIN [Order Details] od ON o.OrderID=od.OrderID
    JOIN Employees e ON e.EmployeeID = o.EmployeeID
    GROUP BY e.EmployeeID, e.City
    ORDER BY SUM(od.Quantity) DESC
) AS MostOrderedCityFROM

-- 11.
-- By using GROUP BY and COUNT(*), e.g. if COUNT(*) > 1 then we delete duplicates