using CompanyCFM.Context;
using CompanyCFM.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CompanyCFM.Services
{
    public class DepartmentsRepository: IDepartmentsRepository
    {
        private readonly ApplicationDbContext _context;

        public DepartmentsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<EmployeesSalariesByDepartmentViewModel> GetEmployeesSalariesByDepartment()
        {
            var sql = @"SELECT d.ID AS Department_Id, d.Name AS Department_name, 
                                COALESCE(SUM(e.Salary), 0) AS Total_Salary
                        FROM Departments d
                        LEFT JOIN Employees e
                        ON d.ID = e.Department_Id
                        GROUP BY d.ID, d.Name;";
            return _context.Set<EmployeesSalariesByDepartmentViewModel>().FromSqlRaw(sql).ToList();
        }
    }
}
