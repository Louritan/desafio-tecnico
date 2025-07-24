using FluentValidation;
using StudentManagement.Communication.Requests;
using StudentManagement.Exception;

namespace StudentManagement.Application.UseCases.Students.Register
{
    public class RegisterStudentGradeValidator : AbstractValidator<RequestRegisterStudentGradeJson>
    {
        public RegisterStudentGradeValidator()
        {
            RuleFor(grade => grade.StudentId).NotNull().WithMessage(ResourceErrorMessages.STUDENT_ID_REQUIRED_ERROR);
            RuleFor(grade => grade.Subject).NotEmpty().WithMessage(ResourceErrorMessages.SUBJECT_REQUIRED_ERROR);
            RuleFor(grade => grade.Grade).GreaterThanOrEqualTo(0).LessThanOrEqualTo(10).WithMessage(ResourceErrorMessages.GRADE_OUT_OF_RANGE_ERROR);
        }
    }
}
