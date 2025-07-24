using StudentManagement.Domain.Entities;
using StudentManagement.Domain.Repositories.Students;

namespace StudentManagement.Infrastructure.DataAccess.Repositories
{
    internal class StudentGradesRepository : IStudentGradesRepository
    {
        private readonly StudentManagementDbContext _dbContext;

        public StudentGradesRepository(StudentManagementDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void Add(StudentGrade studentGrade)
        {
            _dbContext.StudentGrades.Add(studentGrade);
        }
    }
}
