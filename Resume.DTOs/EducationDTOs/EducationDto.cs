namespace Resume.DTOs.EducationDTOs
{
    public class EducationDto
    {
        public string Instituiton { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
