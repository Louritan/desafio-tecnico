using StudentManagement.Communication.Requests;
using StudentManagement.Communication.Responses;

namespace StudentManagement.Application.UseCases.StudentGrades.Register
{
    public interface IRegisterStudentGradeUseCase
    {
        ResponseRegisteredStudentGradeJson Execute(RequestRegisterStudentGradeJson request);
    }
}
