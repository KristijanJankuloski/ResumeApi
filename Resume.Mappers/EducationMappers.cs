using Resume.Domain.Models;
using Resume.DTOs.EducationDTOs;

namespace Resume.Mappers
{
    public static class EducationMappers
    {
        public static EducationDto ToDto(this EducationEntry education)
        {
            return new EducationDto
            {
                Instituiton = education.InstitutionName,
                Title = education.Title,
                Description = education.Description,
                StartDate = education.StartDate,
                EndDate = education.EndDate,
            };
        }
    }
}
