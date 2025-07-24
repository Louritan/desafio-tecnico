using StudentManagement.Application.UseCases.Students.Register;
using StudentManagement.Communication.Requests;
using StudentManagement.Communication.Responses;
using StudentManagement.Domain.Entities;
using StudentManagement.Domain.Repositories;
using StudentManagement.Domain.Repositories.Students;
using StudentManagement.Exception.ExceptionsBase;

namespace StudentManagement.Application.UseCases.StudentGrades.Register
{
    public class RegisterStudentGradeUseCase : IRegisterStudentGradeUseCase
    {
        private readonly IStudentGradesRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public RegisterStudentGradeUseCase(IStudentGradesRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public ResponseRegisteredStudentGradeJson Execute(RequestRegisterStudentGradeJson request)
        {
            Validate(request);

            var entity = new StudentGrade
            {
                StudentId = request.StudentId,
                Subject = request.Subject,
                Grade = request.Grade,
            };

            _repository.Add(entity);
            _unitOfWork.Commit();

            return new ResponseRegisteredStudentGradeJson
            {
                Id = entity.Id
            };
        }

        private void Validate(RequestRegisterStudentGradeJson request)
        {
            var validator = new RegisterStudentGradeValidator();
            var result = validator.Validate(request);
            if (!result.IsValid)
            {
                var errorMessages = result.Errors.Select(f => f.ErrorMessage).ToList();
                throw new ErrorOnValidationException(errorMessages);
            }
        }
    }
}
