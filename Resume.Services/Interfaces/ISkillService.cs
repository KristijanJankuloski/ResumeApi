using Resume.DTOs.SkillDTOs;
using Resume.Shared.Response;

namespace Resume.Services.Interfaces
{
    public interface ISkillService
    {
        Task<Response> Create(string skill);
        Task<List<SkillListDto>> GetAll();
    }
}
