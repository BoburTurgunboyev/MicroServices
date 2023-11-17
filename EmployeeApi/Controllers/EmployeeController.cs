using EmployeeApi.Dtos;
using EmployeeApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService) 
        {
            _employeeService = employeeService;
        }


        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync(EmployeeDto employeeDto)
        {
            var res = await _employeeService.CreateAsync(employeeDto);
            return Ok(res);
        }

        [HttpGet]

        public async ValueTask<IActionResult> GetAllAsync()
        {
            var res = await _employeeService.GetAllAsync();
            return Ok(res);
        }

        [HttpDelete]

        public async ValueTask<IActionResult> DeleteAsync(long id)
        {
            var res = await _employeeService.DeleteASync(id);
            return Ok(res);
        }
    }
}
