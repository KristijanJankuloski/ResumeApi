using Microsoft.AspNetCore.Identity;
using Resume.Domain.Models;
using Resume.DTOs.UserDTOs;
using Resume.Services.AuthService.Interfaces;
using Resume.Shared.Response;

namespace Resume.Services.AuthService.Implementations
{
    public class AuthService : IAuthService
    {
        private readonly ITokenService _tokenService;
        private readonly UserManager<User> _userManager;
        public AuthService(UserManager<User> userManager, ITokenService tokenService)
        {
            _tokenService = tokenService;
            _userManager = userManager;
        }

        public async Task<Response<LoginResponse>> LoginUser(UserLoginDto dto)
        {
            User user = await _userManager.FindByNameAsync(dto.UserName);
            if (user == null)
                return new Response<LoginResponse>("Bad credentials");

            bool result = await _userManager.CheckPasswordAsync(user, dto.Password);
            if(!result)
                return new Response<LoginResponse>("Bad credentials");

            string token = _tokenService.GenerateToken(user);
            return new Response<LoginResponse>(new LoginResponse { Token = token, UserName = user.UserName });
        }

        public async Task<Response> RegisterUser(UserRegisterDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Email) || string.IsNullOrWhiteSpace(dto.Password))
                return new Response("Email and password must not be empty");

            if (dto.Password != dto.ConfirmPassword)
                return new Response("Passwords do no match");

            User user = new User
            {
                UserName = dto.Email,
                Email = dto.Email,
            };
            var result = await _userManager.CreateAsync(user, dto.Password);
            if (!result.Succeeded)
                throw new Exception(string.Join("\n", result.Errors.Select(e => e.Description)));
            return Response.Success;
        }
    }
}
