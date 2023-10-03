using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resume.DTOs.UserDTOs;
using Resume.Services.AuthService.Interfaces;
using Resume.Shared.Response;

namespace Resume.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<ActionResult<Response>> Register(UserRegisterDto dto)
        {
            try
            {
                var response = await _authService.RegisterUser(dto);
                if (!response.IsSuccessful)
                {
                    return BadRequest(response);
                }

                return StatusCode(StatusCodes.Status201Created, response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<ActionResult<Response<LoginResponse>>> Login(UserLoginDto dto)
        {
            try
            {
                var response = await _authService.LoginUser(dto);
                if (!response.IsSuccessful)
                {
                    return BadRequest(response);
                }
                return Ok(response.Result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
