using CompanyCFM.Services;
using Microsoft.AspNetCore.Mvc;

namespace CompanyCFM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersRepository _customersRepository;

        public CustomersController(ICustomersRepository customersRepository)
        {
            _customersRepository = customersRepository;
        }

        [HttpGet]
        public IActionResult GetCustomersWithOrders()
        {
            return Ok(_customersRepository.GetCustomersWithOrders());
        }
    }
}
