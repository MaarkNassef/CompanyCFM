using CompanyCFM.ViewModels;

namespace CompanyCFM.Services
{
    public interface IOrdersRepository
    {
        public List<OrdersWithProductNamesViewModel> GetOrdersWithProductNames();
    }
}
