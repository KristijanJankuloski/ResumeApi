using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resume.DTOs.ResumeDTOs;
using Resume.Services.Interfaces;

namespace Resume.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResumeController : ControllerBase
    {
        private readonly IResumeService _resumeService;
        public ResumeController(IResumeService resumeService)
        {
            _resumeService = resumeService;
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<ResumeDetailsDto>> GetDetails(int id)
        {
            try
            {
                var resume = await _resumeService.GetDetails(id);
                return Ok(resume);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
