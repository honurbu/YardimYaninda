using BspAcademy.Core.Entities;
using BspAcademy.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BspAcademy.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IUserTestService _userTestService;

        public TestController(IUserTestService userTestService)
        {
            _userTestService = userTestService;
        }


        [HttpPost]
        public async Task<IActionResult> TestAdd(UserTest test)
        {
            await _userTestService.AddAsync(test);
            return Ok("Eklendi");

        }


        [HttpGet]
        public async Task<IActionResult> GetTest()
        {
            var values = await _userTestService.GetAllAsync();
            return Ok(values);
        }


        [HttpPut]
        public  async Task<IActionResult> EditTest(UserTest test)
        {
            await _userTestService.UpdateAsync(test);
            return Ok("Güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EditTest(int id)
        {
            var testUser = await _userTestService.GetByIdAsync(id);
            if (testUser != null)
            {
                await _userTestService.RemoveAsync(testUser);
                return Ok("Silindi");
            }

            return BadRequest("Boş");
        }


    }
}
