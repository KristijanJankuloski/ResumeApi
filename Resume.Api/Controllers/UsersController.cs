using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resume.DTOs.UserDTOs;
using Resume.Services.AuthService.Interfaces;
using Resume.Shared.Response;
using System.Security.Claims;

namespace Resume.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IAuthService _authService;
        public UsersController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPatch]
        public async Task<ActionResult<Response>> UpdateUser(UserUpdateDto dto)
        {
            try
            {
                string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                var response = await _authService.UpdateUser(dto, userId);
                if(!response.IsSuccessful) 
                    return BadRequest(response);
                return Ok(response);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
