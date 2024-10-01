using CompanyCFM.Context;
using CompanyCFM.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CompanyCFM.Services
{
    public class EmployeesRepository : IEmployeesRepository
    {
        private readonly ApplicationDbContext _context;
        public EmployeesRepository(ApplicationDbContext context) 
        { 
            this._context = context;
        }
        public List<EmployeeViewModel> GetAll()
        {
            var sql = @"SELECT e.ID AS Employee_Id, e.Name AS Employee_Name,
		                        d.Name AS Department_Name
                        FROM Employees e
                        LEFT JOIN Departments d
                        ON e.Department_Id = d.ID;";
            return _context.Set<EmployeeViewModel>().FromSqlRaw(sql).ToList();
        }
    }
}
