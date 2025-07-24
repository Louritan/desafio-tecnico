namespace StudentManagement.Communication.DTOs
{
    public class StudentGradeDTO
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string Subject { get; set; } = string.Empty;
        public decimal Grade { get; set; }
    }
}
