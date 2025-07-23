using Microsoft.AspNetCore.Mvc;
using StudentManagement.Application.UseCases.Students.Register;
using StudentManagement.Communication.Requests;

namespace StudentManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register(
            [FromServices] IRegisterStudentUseCase useCase,
            [FromBody] RequestRegisterStudentJson request
        )
        {
            var response = useCase.Execute(request);
            return Created(string.Empty, response);
        }
    }
}
