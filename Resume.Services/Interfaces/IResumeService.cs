using Resume.DTOs.ResumeDTOs;

namespace Resume.Services.Interfaces
{
    public interface IResumeService
    {
        Task<ResumeDetailsDto> GetDetails(int id);
    }
}
