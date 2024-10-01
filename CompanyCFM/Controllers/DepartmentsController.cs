using CompanyCFM.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyCFM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentsRepository _departmentsRepository;

        public DepartmentsController(IDepartmentsRepository departmentsRepository)
        {
            _departmentsRepository = departmentsRepository;
        }

        [HttpGet("/api/salary-sum")]
        public IActionResult GetEmployeesSalariesByDepartment() 
        {
            return Ok(_departmentsRepository.GetEmployeesSalariesByDepartment());
        }
    }
}
