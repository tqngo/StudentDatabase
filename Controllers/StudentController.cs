using Microsoft.AspNetCore.Mvc;
using StudentDatabase.Models;
using StudentDatabase.Services;

namespace StudentDatabase.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{

    private readonly IStudentService _studentService;

    public StudentController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    [HttpGet]
    [Route("GetStudent")]

    public List<Student> GetStudents()
    {
        return _studentService.GetStudents();
    }

    [HttpPost]
    [Route("{firstName}/{lastName}/{hobbie}")]
    public List<Student> AddStudent(string firstName, string lastName, string hobbie)
    {
        return _studentService.AddStudent(firstName, lastName, hobbie);
    }

    [HttpDelete]
    [Route("DeleteStudent/{studentName}")]
    public List<Student> DeleteStudent(string firstName)
    {
        return _studentService.DeleteStudent(firstName);
    }
}
