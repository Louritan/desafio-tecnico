namespace StudentManagement.Communication.Requests
{
    public class RequestRegisterStudentGradeJson
    {
        public int StudentId { get; set; }
        public string Subject { get; set; } = string.Empty;
        public decimal Grade { get; set; }
    }
}
