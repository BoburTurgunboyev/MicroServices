using CarApi.Dtos;
using CarApi.Entities;
using CarApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace CarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpPost]
        public async  ValueTask <IActionResult> CreateAsync(CarDto carDto)
        {
            var res = await _carService.CreateAsync(carDto);
            return Ok(res);
        }

        [HttpGet]

        public async ValueTask<IActionResult> GetAllAsync()
        {
            var res =  await _carService.GetAllAsync();
            return Ok(res);
        }

        [HttpDelete]

        public async ValueTask<IActionResult> DeleteAsync(long id)
        {
            var res = await _carService.DeleteASync(id);
            return Ok(res);
        }
       
    }
}
