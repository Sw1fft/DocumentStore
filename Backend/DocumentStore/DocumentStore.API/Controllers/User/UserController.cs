using DocumentStore.API.DTO.User.Request;
using DocumentStore.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DocumentStore.API.Controllers.User
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("/login")]
        public async Task<IActionResult> LoginUser([FromBody] LoginRequestDTO loginRequest)
        {
            var token = await _userService.LoginUser(loginRequest.Email, loginRequest.Password);

            Response.Cookies.Append("documentStore", token);

            return Ok(token);
        }

        [HttpPost]
        [Route("/register")]
        public async Task RegisterUser([FromBody] RegisterRequestDTO registerRequest)
        {
            await _userService.RegisterUser(
                registerRequest.Email,
                registerRequest.Login,
                registerRequest.Password,
                registerRequest.PasswordConf);
        }
    }
}
