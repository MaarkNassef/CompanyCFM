using CompanyCFM.ViewModels;

namespace CompanyCFM.Services
{
    public interface ICustomersRepository
    {
        public List<CustomersWithOrdersViewModel> GetCustomersWithOrders();
    }
}
