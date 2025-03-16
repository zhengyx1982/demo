using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using MyWebApi.Services;
using MyWebApi.Dto;
using Microsoft.AspNetCore.Authorization;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserRegistrationDto userDto)
        {
            var result = await _userService.RegisterAsync(userDto.Username, userDto.Email, userDto.Password);
            return Ok(result);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDto userDto)
        {
            var token = await _userService.LoginAsync(userDto.Username, userDto.Password);
            return Ok(new { token });
        }

        [HttpGet("profile")]
        [Authorize]
        public IActionResult GetProfile()
        {
            return Ok(new { Message = "This is a protected endpoint" });
        }
    }
}
