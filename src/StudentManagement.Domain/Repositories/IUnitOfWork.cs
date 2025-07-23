namespace StudentManagement.Domain.Repositories
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
