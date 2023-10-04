using Resume.DTOs.ResumeDTOs;
using Resume.Shared.Response;

namespace Resume.Services.Interfaces
{
    public interface IResumeService
    {
        Task<ResumeDetailsDto> GetDetails(int id);
        Task<Response> CreateResume(ResumeCreateDto dto, string userId);
    }
}
