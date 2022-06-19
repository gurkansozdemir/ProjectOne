using Microsoft.AspNetCore.Mvc;
using OBS.Core.Entities;
using OBS.Core.Services;

namespace OBS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IService<User> _service;

        public UsersController(IService<User> service)
        {
            _service = service;
        }
        
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var users = await _service.GetAllAsync();
            return Ok(users);
        }
    }
}
