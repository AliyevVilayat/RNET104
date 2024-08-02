using RNET104_02082024.Business.Abstractions.Repositories;
using RNET104_02082024.Business.Concretes.Repositories;
using RNET104_02082024.Contexts;
using RNET104_02082024.Models;

namespace RNET104_02082024.Business;

public class StudentService
{
    private readonly AcademyDBContext _context;
    public StudentService()
    {
        _context = new AcademyDBContext();
    }
    public void AddStudent(Student student)
    {
        _context.Students.Add(student);
        _context.SaveChanges();
    }

    public void UpdateStudent(Student student)
    {

        _context.Students.Update(student);
        _context.SaveChanges();
    }
}

public class TeacherService
{
    private readonly AcademyDBContext _context;
    private readonly IReadRepository<Teacher> readRepository;

    public TeacherService()
    {
        _context = new AcademyDBContext();
        readRepository = new ReadRepository<Teacher>();
    }

    public Teacher GetTeacherById(int id)
    {
        Teacher teacher = readRepository.GetById(id);
        return teacher;
    }

}
