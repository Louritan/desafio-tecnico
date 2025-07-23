namespace StudentManagement.Domain.Entities
{
    public class StudentGrade
    {
        public long Id { get; set; }
        public long StudentId { get; set; }
        public string Subject { get; set; } = string.Empty;
        public decimal Grade { get; set; }

        public Student? Student { get; set; }
    }
}
