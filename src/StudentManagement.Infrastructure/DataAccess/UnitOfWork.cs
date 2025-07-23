using StudentManagement.Domain.Repositories;

namespace StudentManagement.Infrastructure.DataAccess
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly StudentManagementDbContext _dbContext;

        public UnitOfWork(StudentManagementDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void Commit()
        {
            this._dbContext.SaveChanges();
        }
    }
}
