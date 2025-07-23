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
    }
}
