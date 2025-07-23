using StudentManagement.Communication.Requests;
using StudentManagement.Communication.Responses;

namespace StudentManagement.Application.UseCases.Student.Register
{
    public class RegisterStudentUseCase
    {
        public ResponseRegisteredStudentJson Execute(RequestRegisterStudentJson request)
        {
            Validate(request);
            return new ResponseRegisteredStudentJson();
        }

        private void Validate(RequestRegisterStudentJson request)
        {
            var nameIsEmpty = string.IsNullOrWhiteSpace(request.Name);

            if (nameIsEmpty)
                throw new ArgumentException("Name is required!");

            if (request.Age <= 0)
                throw new ArgumentException("Age must be greater than zero!");
        }
    }
}
