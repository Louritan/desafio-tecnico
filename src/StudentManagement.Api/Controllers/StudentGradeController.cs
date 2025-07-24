using Microsoft.AspNetCore.Mvc;
using StudentManagement.Application.UseCases.StudentGrades.Register;
using StudentManagement.Communication.Requests;

namespace StudentManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentGradeController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register(
            [FromServices] IRegisterStudentGradeUseCase useCase,
            [FromBody] RequestRegisterStudentGradeJson request
        )
        {
            var response = useCase.Execute(request);
            return Created(string.Empty, response);
        }
    }
}
