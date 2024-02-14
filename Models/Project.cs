namespace CourseWork.Models
{
    public class Organisation
    {
        public int Id { get; set; }
        public string? Deadline { get; set; }
        public string? Description { get; set; }
        public int? Duration { get; set; }
        public Department? Department { get; set; }
    }
}
