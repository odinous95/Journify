using Microsoft.AspNetCore.Mvc;
using UserManagment.service.Interfaces;

namespace UserManagment.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetUserByIdAsync(Guid id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null) return NotFound("User not found.");
            return Ok(user);

        }

        [HttpPost]
        public async Task<ActionResult> CreateUser([FromBody] Journify.core.Entities.User user)
        {
            if (user == null) return BadRequest("User data is null.");
            var createdUser = await _userService.AddUserAsync(user);
            return Ok(createdUser);

        }
        [HttpGet]
        public async Task<ActionResult> GetAllUsersAsync()
        {
            var users = await _userService.GetAllUsersAsync();
            if (users == null) return NotFound("No users found.");
            return Ok(users);
        }
    }
}
