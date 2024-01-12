using StudentDatabase.Data;
using StudentDatabase.Models;

namespace StudentDatabase.Services;

public class StudentService : IStudentService
{
    private readonly DataContext _db;

    public StudentService(DataContext db)
    {
        _db = db;
    }

    public List<Student> AddStudent(string firstName, string lastName, string hobbie)
    {
        Student newFirst = new();
        newFirst.FirstName = firstName;
        newFirst.LastName = lastName;
        newFirst.Hobbie = hobbie;


        _db.Students.Add(newFirst);
        _db.SaveChanges();

        return _db.Students.ToList();
    }

    public List<Student> DeleteStudent(string firstName)
    {
       var student = _db.Students.FirstOrDefault(foundStudent => foundStudent.FirstName == firstName);
       if(student != null)
       {
        _db.Students.Remove(student);
        _db.SaveChanges();
       }
       return _db.Students.ToList();
    }

    public List<Student> GetStudents()
    {
        return _db.Students.ToList();
    }
}
