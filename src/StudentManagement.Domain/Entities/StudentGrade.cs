using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagement.Domain.Entities
{
    public class StudentGrade
    {
        public int Id { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public string Subject { get; set; } = string.Empty;
        public decimal Grade { get; set; }

        public Student? Student { get; set; }
    }
}
