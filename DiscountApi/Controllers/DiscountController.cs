using DiscountApi.Dtos;
using DiscountApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DiscountApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;

        public DiscountController(IDiscountService discountService)
        {
            _discountService = discountService;
        }


        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync(DiscountDto componyDto)
        {
            var res = await _discountService.CreateAsync(componyDto);
            return Ok(res);
        }

        [HttpGet]

        public async ValueTask<IActionResult> GetAllAsync()
        {
            var res = await _discountService.GetAllAsync();
            return Ok(res);
        }

        [HttpDelete]

        public async ValueTask<IActionResult> DeleteAsync(long id)
        {
            var res = await _discountService.DeleteASync(id);
            return Ok(res);
        }
    }
}
