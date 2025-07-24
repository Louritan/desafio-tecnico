using StudentManagement.Communication.Responses;

namespace StudentManagement.Application.UseCases.Students.GetStudents
{
    public interface IGetStudentsUseCase
    {
        ResponseGetStudentsJson Execute();
    }
}
