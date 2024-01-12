using StudentDatabase.Models;

namespace StudentDatabase.Services;

    public interface IStudentService
    {
    List<Student> GetStudents();
    List<Student> AddStudent(string firstName, string lastName, string hobbie);
    List<Student> DeleteStudent(string firstName);
    }
