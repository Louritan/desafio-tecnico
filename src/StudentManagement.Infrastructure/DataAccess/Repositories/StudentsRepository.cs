using StudentManagement.Domain.Entities;
using StudentManagement.Domain.Repositories.Students;

namespace StudentManagement.Infrastructure.DataAccess.Repositories
{
    internal class StudentsRepository : IStudentsRepository
    {
        private readonly StudentManagementDbContext _dbContext;

        public StudentsRepository(StudentManagementDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void Add(Student student)
        {
            _dbContext.Students.Add(student);
        }

        public List<Student> GetAll()
        {
            return _dbContext.Students.ToList();
        }

        public List<StudentGrade> GetStudentGrades(int studentId)
        {
            return _dbContext.StudentGrades.Where(x => x.StudentId == studentId).ToList();
        }
    }
}
