using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resume.DTOs.SkillDTOs;
using Resume.Services.Interfaces;
using Resume.Shared.Response;

namespace Resume.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SkillsController : ControllerBase
    {
        private readonly ISkillService _skillService;
        public SkillsController(ISkillService skillService)
        {
            _skillService = skillService;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<List<SkillListDto>>> GetAll()
        {
            try
            {
                var skills = await _skillService.GetAll();
                return Ok(skills);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Response>> CrateSkill(SkillCreateDto dto)
        {
            try
            {
                var response = await _skillService.Create(dto.Name);
                if(!response.IsSuccessful) 
                    return BadRequest(response);
                return StatusCode(StatusCodes.Status201Created, response);
            }
            catch (Exception ex) 
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
