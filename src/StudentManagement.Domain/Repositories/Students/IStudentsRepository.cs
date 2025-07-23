using StudentManagement.Domain.Entities;

namespace StudentManagement.Domain.Repositories.Students
{
    public interface IStudentsRepository
    {
        void Add(Student student);
    }
}
