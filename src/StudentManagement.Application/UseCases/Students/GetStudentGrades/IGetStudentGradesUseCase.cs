using StudentManagement.Communication.Responses;

namespace StudentManagement.Application.UseCases.Students.GetStudentGrades
{
    public interface IGetStudentGradesUseCase
    {
        ResponseGetStudentGradesJson Execute(int studentId);
    }
}
