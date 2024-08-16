using DotNetProject.Models;
using DotNetProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNetProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser service;

        public UserController(IUser userService)
        {
            this.service = userService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserById(string id)
        {
            var user = await service.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost("register")]
        public async Task<ActionResult<User>> CreateUser([FromBody] User user)
        {
            var result = await service.CreateUser(user);
            return CreatedAtAction(nameof(GetUserById), new { id = result.Userid }, result);
        }
    }
}
