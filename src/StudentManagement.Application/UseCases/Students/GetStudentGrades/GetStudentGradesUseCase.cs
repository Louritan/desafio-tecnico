using StudentManagement.Communication.DTOs;
using StudentManagement.Communication.Responses;
using StudentManagement.Domain.Repositories;
using StudentManagement.Domain.Repositories.Students;

namespace StudentManagement.Application.UseCases.Students.GetStudentGrades
{
    public class GetStudentGradesUseCase : IGetStudentGradesUseCase
    {
        private readonly IStudentsRepository _repository;

        public GetStudentGradesUseCase(IStudentsRepository repository, IUnitOfWork unitOfWork)
        {
            this._repository = repository;
        }

        public ResponseGetStudentGradesJson Execute(int studentId)
        {
            var grades = _repository.GetStudentGrades(studentId);

            var gradesDTO = grades.Select(grade => new StudentGradeDTO
            {
                Id = grade.Id,
                StudentId = grade.StudentId,
                Subject = grade.Subject,
                Grade = grade.Grade
            }).ToList();

            return new ResponseGetStudentGradesJson
            {
                StudentGrades = gradesDTO
            };
        }
    }
}
