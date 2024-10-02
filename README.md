# CompanyCFM - ContrackFM Technical Assessment

## Project Overview

This project is part of a technical assessment for ContrackFM. It involves building an **ASP.NET Core Web API** to showcase technical skills.

## Technologies Used

- **ASP.NET Core Web API**
- **Entity Framework Core**
- **SQL Server**

## Setup Instructions

1. **Clone the repository**:
   ```bash
   git clone https://github.com/MaarkNassef/CompanyCFM.git
   ```

2. **Set up the database**:
   - Open **SQL Server Management Studio (SSMS)**.
   - Navigate to the file [`CompanyCFM\SqlQueries\SQLQueriesForDBCreation.sql`](https://github.com/MaarkNassef/CompanyCFM/blob/master/CompanyCFM/SqlQueries/SQLQueriesForDBCreation.sql).
   - Execute the SQL queries to create the necessary database and tables.

<!-- Already included in packages
3. **Configure Entity Framework Core**:
   Install the following NuGet packages:
   - `Microsoft.EntityFrameworkCore`
   - `Microsoft.EntityFrameworkCore.Design`
   - `Microsoft.EntityFrameworkCore.Tools`
   - `Microsoft.EntityFrameworkCore.SqlServer`

   You can install these packages via the NuGet Package Manager in Visual Studio or using the command line:
   ```bash
   dotnet add package Microsoft.EntityFrameworkCore
   dotnet add package Microsoft.EntityFrameworkCore.Design
   dotnet add package Microsoft.EntityFrameworkCore.Tools
   dotnet add package Microsoft.EntityFrameworkCore.SqlServer
   ```
-->

3. **Update the database connection string**:
   Ensure the connection string in `appsettings.json` is correctly pointing to your local or remote SQL Server instance.

4. **Run the project**:
   ```bash
   dotnet run
   ```

## Usage

You can interact with the API using the following methods:

- **Postman**: Use Postman to send HTTP requests and test the API endpoints.
- **Browser**: Open your browser and navigate to the Swagger UI, which is automatically generated for the project. It allows you to explore and test the API endpoints in a user-friendly interface.

Swagger UI is typically accessible at:
```
http://localhost:<port>/swagger
```

## API Endpoints
1. **`GET /api/employees`**: List of all employees with their ID, name, and department name.

   ```json
   [
    {
      "employee_Id": 1,
      "employee_Name": "Ahmed",
      "department_Name": "Human Resources"
    },
    {
      "employee_Id": 2,
      "employee_Name": "Mohamed",
      "department_Name": "IT"
    },
    {
      "employee_Id": 3,
      "employee_Name": "Peter",
      "department_Name": "Operations"
    },
    {
      "employee_Id": 4,
      "employee_Name": "Clara",
      "department_Name": "Accounting and Finance"
    },
    {
      "employee_Id": 5,
      "employee_Name": "Beeshoy",
      "department_Name": "Accounting and Finance"
    },
    {
      "employee_Id": 6,
      "employee_Name": "Menna",
      "department_Name": "Operations"
    },
    {
      "employee_Id": 7,
      "employee_Name": "Gina",
      "department_Name": "Human Resources"
    }
   ]
   ```

2. **`GET /api/customers`**: List of all customers with their ID, name, all associated orders (ID, Amount), product  names, and total costs.

  ```json
  [
    {
      "customer_Id": "CI-001",
      "customer_Name": "Customer 1",
      "order_Id": null,
      "amount": null,
      "product_Name": null,
      "total_Cost": null
    },
    {
      "customer_Id": "CI-002",
      "customer_Name": "Customer 2",
      "order_Id": "D-01",
      "amount": 5,
      "product_Name": "Product 1",
      "total_Cost": 500.25
    },
    {
      "customer_Id": "CI-003",
      "customer_Name": "Customer 3",
      "order_Id": null,
      "amount": null,
      "product_Name": null,
      "total_Cost": null
    },
    {
      "customer_Id": "CI-004",
      "customer_Name": "Customer 4",
      "order_Id": "D-02",
      "amount": 8,
      "product_Name": "Product 2",
      "total_Cost": 1203.2
    },
    {
      "customer_Id": "CI-004",
      "customer_Name": "Customer 4",
      "order_Id": "D-03",
      "amount": 4,
      "product_Name": "Product 4",
      "total_Cost": 3162
    },
    {
      "customer_Id": "CI-005",
      "customer_Name": "Customer 5",
      "order_Id": "D-04",
      "amount": 3,
      "product_Name": "Product 6",
      "total_Cost": 601.5
    }
  ]
  ```
   
3. **`GET /api/orders`**:  List of all orders with product names, ordered by order ID in descending order.

  ```json
  [
    {
      "order_Id": "D-04",
      "product_Id": 105,
      "product_name": "Product 6"
    },
    {
      "order_Id": "D-03",
      "product_Id": 103,
      "product_name": "Product 4"
    },
    {
      "order_Id": "D-02",
      "product_Id": 101,
      "product_name": "Product 2"
    },
    {
      "order_Id": "D-01",
      "product_Id": 100,
      "product_name": "Product 1"
    }
  ]
  ```
  
4. **`GET /api/salary-sum`**:  Sum of employees’ salaries for each department.

  ```json
  [
    {
      "department_Id": 1,
      "department_name": "IT",
      "total_Salary": 4000
    },
    {
      "department_Id": 2,
      "department_name": "Operations",
      "total_Salary": 8500
    },
    {
      "department_Id": 3,
      "department_name": "Human Resources",
      "total_Salary": 14400
    },
    {
      "department_Id": 4,
      "department_name": "Accounting and Finance",
      "total_Salary": 13000
    },
    {
      "department_Id": 5,
      "department_name": "Research and Development (R&D)",
      "total_Salary": 0
    }
  ]
  ```

  If you want to get all select queries for this assessment in one file, you can find them at [`CompanyCFM\SqlQueries\SQLQueriesForEachPoint.sql`](https://github.com/MaarkNassef/CompanyCFM/blob/master/CompanyCFM/SqlQueries/SQLQueriesForEachPoint.sql).
  
