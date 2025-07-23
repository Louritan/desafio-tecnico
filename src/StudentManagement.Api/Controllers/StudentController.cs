using Microsoft.AspNetCore.Mvc;
using StudentManagement.Application.UseCases.Student.Register;
using StudentManagement.Communication.Requests;

namespace StudentManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register([FromBody] RequestRegisterStudentJson request)
        {
            var useCase = new RegisterStudentUseCase();
            var response = useCase.Execute(request);
            return Created(string.Empty, response);
        }
    }
}
