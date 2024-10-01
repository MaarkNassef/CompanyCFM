using CompanyCFM.ViewModels;

namespace CompanyCFM.Services
{
    public interface IDepartmentsRepository
    {
        public List<EmployeesSalariesByDepartmentViewModel> GetEmployeesSalariesByDepartment();
    }
}
