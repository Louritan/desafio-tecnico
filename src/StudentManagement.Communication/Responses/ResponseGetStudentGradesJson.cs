using StudentManagement.Communication.DTOs;

namespace StudentManagement.Communication.Responses
{
    public class ResponseGetStudentGradesJson
    {
        public List<StudentGradeDTO> StudentGrades { get; set; } = new();
    }
}
