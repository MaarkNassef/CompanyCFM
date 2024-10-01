namespace CompanyCFM.ViewModels
{
    public class CustomersWithOrdersViewModel
    {
        public string Customer_Id { get; set; }
        public string Customer_Name { get; set; }
        public string? Order_Id { get; set; }
        public int? Amount { get; set; }
        public string? Product_Name { get; set; }
        public decimal? Total_Cost { get; set; }
    }
}
