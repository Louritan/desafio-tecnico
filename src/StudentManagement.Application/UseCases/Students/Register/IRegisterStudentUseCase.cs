using StudentManagement.Communication.Requests;
using StudentManagement.Communication.Responses;

namespace StudentManagement.Application.UseCases.Students.Register
{
    public interface IRegisterStudentUseCase
    {
        ResponseRegisteredStudentJson Execute(RequestRegisterStudentJson request);
    }
}
