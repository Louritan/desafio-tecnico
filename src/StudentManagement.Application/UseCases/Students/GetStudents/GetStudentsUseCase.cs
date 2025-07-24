using StudentManagement.Communication.DTOs;
using StudentManagement.Communication.Responses;
using StudentManagement.Domain.Repositories;
using StudentManagement.Domain.Repositories.Students;

namespace StudentManagement.Application.UseCases.Students.GetStudents
{
    public class GetStudentsUseCase : IGetStudentsUseCase
    {
        private readonly IStudentsRepository _repository;

        public GetStudentsUseCase(IStudentsRepository repository, IUnitOfWork unitOfWork)
        {
            this._repository = repository;
        }

        public ResponseGetStudentsJson Execute()
        {
            var students = _repository.GetAll();

            var studentsDTO = students.Select(student => new StudentDTO
            {
                Id = student.Id,
                Name = student.Name,
                Age = student.Age,
            }).ToList();

            return new ResponseGetStudentsJson
            {
                Students = studentsDTO
            };
        }
    }
}
