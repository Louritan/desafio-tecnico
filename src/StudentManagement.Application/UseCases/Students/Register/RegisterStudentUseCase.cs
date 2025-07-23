using StudentManagement.Communication.Requests;
using StudentManagement.Communication.Responses;
using StudentManagement.Domain.Entities;
using StudentManagement.Domain.Repositories;
using StudentManagement.Domain.Repositories.Students;
using StudentManagement.Exception.ExceptionsBase;

namespace StudentManagement.Application.UseCases.Students.Register
{
    public class RegisterStudentUseCase : IRegisterStudentUseCase
    {
        private readonly IStudentsRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public RegisterStudentUseCase(IStudentsRepository repository, IUnitOfWork unitOfWork)
        {
            this._repository = repository;
            this._unitOfWork = unitOfWork;
        }

        public ResponseRegisteredStudentJson Execute(RequestRegisterStudentJson request)
        {
            Validate(request);

            var entity = new Student
            {
                Name = request.Name,
                Age = request.Age,
            };

            _repository.Add(entity);
            _unitOfWork.Commit();
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
