using Resume.DataAccess.Repository.Interfaces;
using Resume.Domain.Models;
using Resume.DTOs.ResumeDTOs;
using Resume.Mappers;
using Resume.Services.Interfaces;
using Resume.Shared.Response;

namespace Resume.Services.Implementations
{
    public class ResumeService : IResumeService
    {
        private readonly IResumeRepository _repository;
        public ResumeService(IResumeRepository resumeRepository)
        {
            _repository = resumeRepository;
        }

        public Task<Response> CreateResume(ResumeCreateDto dto, string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<ResumeDetailsDto> GetDetails(int id)
        {
            UserResume resume = await _repository.GetByIdAsync(id);
            if (resume == null) 
                return null;
            return resume.ToDetailsDto();
        }
    }
}
