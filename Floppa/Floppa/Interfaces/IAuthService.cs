using Floppa.Models.DTOs;

namespace Floppa.Interfaces;

public interface IAuthService
{
    public Task SignUpUserAsync(RegisterUser registerUser);
    public Task SignInUserAsync();
}
