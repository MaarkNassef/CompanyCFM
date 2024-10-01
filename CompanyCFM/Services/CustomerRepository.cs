using CompanyCFM.Context;
using CompanyCFM.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CompanyCFM.Services
{
    public class CustomerRepository: ICustomersRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<CustomersWithOrdersViewModel> GetCustomersWithOrders()
        {
            var sql = @"SELECT c.ID AS Customer_Id, c.Name AS Customer_Name,
		                        o.ID AS Order_Id, o.Amount AS Amount, 
		                        p.Name AS Product_Name, (p.Cost * o.Amount) AS Total_Cost
                        FROM Customers c
                        LEFT JOIN Orders o
                        ON c.ID = o.Customer_Id
                        LEFT JOIN Products p
                        ON p.ID = o.Product_Id;";
            return _context.Set<CustomersWithOrdersViewModel>().FromSqlRaw(sql).ToList();
        }
    }
}
