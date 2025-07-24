using StudentManagement.Domain.Entities;

namespace StudentManagement.Domain.Repositories.Students
{
    public interface IStudentGradesRepository
    {
        void Add(StudentGrade studentGrade);
    }
}
