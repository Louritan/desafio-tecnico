using StudentManagement.Communication.Requests;
using StudentManagement.Communication.Responses;
using StudentManagement.Exception.ExceptionsBase;

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
            var validator = new RegisterStudentValidator();
            var result = validator.Validate(request);
            if (!result.IsValid)
            {
                var errorMessages = result.Errors.Select(f => f.ErrorMessage).ToList();
                throw new ErrorOnValidationException(errorMessages);
            }
        }
    }
}
