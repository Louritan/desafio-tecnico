using Microsoft.Extensions.DependencyInjection;
using StudentManagement.Application.UseCases.StudentGrades.Register;
using StudentManagement.Application.UseCases.Students.GetStudentGrades;
using StudentManagement.Application.UseCases.Students.GetStudents;
using StudentManagement.Application.UseCases.Students.Register;

namespace StudentManagement.Application
{
    public static class DependencyInjectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IRegisterStudentUseCase, RegisterStudentUseCase>();
            services.AddScoped<IRegisterStudentGradeUseCase, RegisterStudentGradeUseCase>();
            services.AddScoped<IGetStudentsUseCase, GetStudentsUseCase>();
            services.AddScoped<IGetStudentGradesUseCase, GetStudentGradesUseCase>();
        }
    }
}
