using CompanyCFM.Context;
using CompanyCFM.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CompanyCFM.Services
{
    public class OrdersRepository: IOrdersRepository
    {
        private readonly ApplicationDbContext _context;

        public OrdersRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<OrdersWithProductNamesViewModel> GetOrdersWithProductNames()
        {
            var sql = @"SELECT o.ID AS Order_Id, p.ID AS Product_Id,
		                        p.Name AS Product_name
                        FROM Orders o
                        LEFT JOIN Products p
                        ON o.Product_Id = p.ID
                        ORDER BY o.ID DESC;";
            return _context.Set<OrdersWithProductNamesViewModel>().FromSqlRaw(sql).ToList();
        }
    }
}
