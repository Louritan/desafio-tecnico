using Microsoft.AspNetCore.Mvc;
using StudentManagement.Application.UseCases.Students.GetStudentGrades;
using StudentManagement.Application.UseCases.Students.GetStudents;
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

        [HttpGet]
        public IActionResult Get([FromServices] IGetStudentsUseCase useCase)
        {
            var response = useCase.Execute();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetGradesByStudentId(
            [FromServices] IGetStudentGradesUseCase useCase,
            [FromRoute] int id
        )
        {
            var response = useCase.Execute(id);
            return Ok(response);
        }
    }
}
