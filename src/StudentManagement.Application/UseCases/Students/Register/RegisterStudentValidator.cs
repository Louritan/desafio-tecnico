using FluentValidation;
using StudentManagement.Communication.Requests;
using StudentManagement.Exception;

namespace StudentManagement.Application.UseCases.Students.Register
{
    public class RegisterStudentValidator : AbstractValidator<RequestRegisterStudentJson>
    {
        public RegisterStudentValidator()
        {
            RuleFor(student => student.Name).NotEmpty().WithMessage(ResourceErrorMessages.NAME_REQUIRED_ERROR);
            RuleFor(student => student.Age).GreaterThan(0).WithMessage(ResourceErrorMessages.AGE_MUST_BE_GRATER_THAN_ZERO_ERROR);
        }
    }
}
