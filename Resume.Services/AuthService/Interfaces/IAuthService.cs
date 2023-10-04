using Resume.DTOs.UserDTOs;
using Resume.Shared.Response;

namespace Resume.Services.AuthService.Interfaces
{
    public interface IAuthService
    {
        Task<Response> RegisterUser(UserRegisterDto dto);
        Task<Response<LoginResponse>> LoginUser(UserLoginDto dto);
        Task<Response> UpdateUser(UserUpdateDto dto, string userId);
    }
}
