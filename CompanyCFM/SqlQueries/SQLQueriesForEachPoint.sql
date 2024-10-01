--Get All Employees
SELECT e.ID AS Employee_Id, e.Name AS Employee_Name,
		d.Name AS Department_Name
FROM Employees e
LEFT JOIN Departments d
ON e.Department_Id = d.ID;

--Get All Customers with Orders
SELECT c.ID AS Customer_Id, c.Name AS Customer_Name,
		o.ID AS Order_Id, o.Amount AS Amount, 
		p.Name AS Product_Name, (p.Cost * o.Amount) AS Total_Cost
FROM Customers c
LEFT JOIN Orders o
ON c.ID = o.Customer_Id
LEFT JOIN Products p
ON p.ID = o.Product_Id;

--Get All Orders with Product Names
SELECT o.ID AS Order_Id, p.ID AS Product_Id,
		p.Name AS Product_name
FROM Orders o
LEFT JOIN Products p
ON o.Product_Id = p.ID
ORDER BY o.ID DESC;

--Sum of Employee Salaries by Department
SELECT d.ID AS Department_Id, d.Name AS Department_name, COALESCE(SUM(e.Salary), 0) AS Total_Salary
FROM Departments d
LEFT JOIN Employees e
ON d.ID = e.Department_Id
GROUP BY d.ID, d.Name;