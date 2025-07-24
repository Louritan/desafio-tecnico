using StudentManagement.Communication.DTOs;

namespace StudentManagement.Communication.Responses
{
    public class ResponseGetStudentsJson
    {
        public List<StudentDTO> Students { get; set; } = new();
    }
}
