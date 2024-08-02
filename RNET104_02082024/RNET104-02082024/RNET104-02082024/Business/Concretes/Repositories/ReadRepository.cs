using Microsoft.EntityFrameworkCore;
using RNET104_02082024.Business.Abstractions.Repositories;
using RNET104_02082024.Contexts;

namespace RNET104_02082024.Business.Concretes.Repositories;


public class ReadRepository<T> : IReadRepository<T> where T : class
{
    private readonly AcademyDBContext _context;

    //Gelecekde Constructor Dependency Injection olacaq
    public ReadRepository()
    {
        _context = new AcademyDBContext();
    }

    public DbSet<T> Table => _context.Set<T>();

    public List<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public T GetById(int id)
    {
        T? entity = Table.Find(id);
        if (entity == null)
        {

            throw new Exception($"Entity not found with this id {id}");
        }

        return entity;
    }
}

