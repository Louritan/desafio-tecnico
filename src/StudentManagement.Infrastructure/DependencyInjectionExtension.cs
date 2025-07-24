using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentManagement.Domain.Repositories;
using StudentManagement.Domain.Repositories.Students;
using StudentManagement.Infrastructure.DataAccess;
using StudentManagement.Infrastructure.DataAccess.Repositories;

namespace StudentManagement.Infrastructure
{
    public static class DependencyInjectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            AddDbContext(services, configuration);
            AddRepositories(services);
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IStudentsRepository, StudentsRepository>();
            services.AddScoped<IStudentGradesRepository, StudentGradesRepository>();
        }

        private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Connection");
            services.AddDbContext<StudentManagementDbContext>(config => config.UseNpgsql(connectionString));
        }
    }
}
