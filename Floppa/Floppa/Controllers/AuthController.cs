using Floppa.Interfaces;
using Floppa.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Floppa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthService authService) : ControllerBase
    {
        [HttpPost]
        [Route("SignUp")]
        public async Task<IActionResult> SignUp(RegisterUser registerUser)
        {
            await authService.SignUpUserAsync(registerUser);
            return Ok();
        }

        [HttpPost]
        [Route("SignIn")]
        public async Task<IActionResult> SignIn()
        {
            return Ok();
        }
    }
}
