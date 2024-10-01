using CompanyCFM.ViewModels;

namespace CompanyCFM.Services
{
    public interface IEmployeesRepository
    {
        public List<EmployeeViewModel> GetAll();
    }
}
