--Run the following line by line
CREATE DATABASE Company;

USE Company;

--Run the following togeather
CREATE TABLE Departments (
    ID INT PRIMARY KEY,
    Name VARCHAR(100)
);

CREATE TABLE Employees (
    ID INT PRIMARY KEY,
    Name VARCHAR(50),
    Salary DECIMAL(10, 2),
    Department_Id INT,
    FOREIGN KEY (Department_Id) REFERENCES Departments(ID)
);

CREATE TABLE Customers (
    ID VARCHAR(10) PRIMARY KEY,
    Name VARCHAR(100),
    Address VARCHAR(100)
);

CREATE TABLE Products (
    ID INT PRIMARY KEY,
    Name VARCHAR(100),
    Cost DECIMAL(10, 2)
);

CREATE TABLE Orders (
    ID VARCHAR(10) PRIMARY KEY,
    Customer_Id VARCHAR(10),
    Product_Id INT,
    Amount INT,
    FOREIGN KEY (Customer_Id) REFERENCES Customers(ID),
    FOREIGN KEY (Product_Id) REFERENCES Products(ID)
);

INSERT INTO Departments (ID, Name) VALUES
(1, 'IT'),
(2, 'Operations'),
(3, 'Human Resources'),
(4, 'Accounting and Finance'),
(5, 'Research and Development (R&D)');

INSERT INTO Employees (ID, Name, Salary, Department_Id) VALUES
(1, 'Ahmed', 5000, 3),
(2, 'Mohamed', 4000, 1),
(3, 'Peter', 3000, 2),
(4, 'Clara', 6000, 4),
(5, 'Beeshoy', 7000, 4),
(6, 'Menna', 5500, 2),
(7, 'Gina', 9400, 3);

INSERT INTO Customers (ID, Name, Address) VALUES
('CI-001', 'Customer 1', 'Cairo'),
('CI-002', 'Customer 2', 'Cairo'),
('CI-003', 'Customer 3', 'Giza'),
('CI-004', 'Customer 4', 'Banha'),
('CI-005', 'Customer 5', 'Alex');

INSERT INTO Products (ID, Name, Cost) VALUES
(100, 'Product 1', 100.05),
(101, 'Product 2', 150.40),
(102, 'Product 3', 800.50),
(103, 'Product 4', 790.50),
(104, 'Product 5', 500.00),
(105, 'Product 6', 200.50);

INSERT INTO Orders (ID, Customer_Id, Product_Id, Amount) VALUES
('D-01', 'CI-002', 100, 5),
('D-02', 'CI-004', 101, 8),
('D-03', 'CI-004', 103, 4),
('D-04', 'CI-005', 105, 3);