namespace CourseWork.Models
{
    public class Staff
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public Department? Department { get; set; }
    }
}
