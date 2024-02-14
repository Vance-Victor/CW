namespace CourseWork.Models
{
    public class StaffSkill
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public Staff? Staff { get; set; }
        public Skill? Skill { get; set; }
    }
}
