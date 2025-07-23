using Microsoft.Extensions.DependencyInjection;
using StudentManagement.Application.UseCases.Students.Register;

namespace StudentManagement.Application
{
    public static class DependencyInjectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IRegisterStudentUseCase, RegisterStudentUseCase>();
        }
    }
}
