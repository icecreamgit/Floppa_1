using Microsoft.AspNetCore.Mvc;

namespace Floppa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        [Route("SignUp")]
        public async Task<IActionResult> SignUp()
        {
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
