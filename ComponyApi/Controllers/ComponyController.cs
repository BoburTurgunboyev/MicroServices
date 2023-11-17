using ComponyApi.Dtos;
using ComponyApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComponyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComponyController : ControllerBase
    {
       private readonly IComponyService _componyService;

        public ComponyController(IComponyService componyService)
        {
            _componyService = componyService;
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync(ComponyDto componyDto)
        {
            var res = await _componyService.CreateAsync(componyDto);
            return Ok(res);
        }

        [HttpGet]

        public async ValueTask<IActionResult> GetAllAsync()
        {
            var res = await _componyService.GetAllAsync();
            return Ok(res);
        }

        [HttpDelete]

        public async ValueTask<IActionResult> DeleteAsync(long id)
        {
            var res = await _componyService.DeleteASync(id);
            return Ok(res);
        }

    }
}
