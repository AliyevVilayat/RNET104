using Microsoft.EntityFrameworkCore;
using RNET104_02082024.Business.Abstractions.Repositories;
using RNET104_02082024.Contexts;

namespace RNET104_02082024.Business.Concretes.Repositories;

public class WriteRepository<T> : IWriteRepository<T> where T : class
{
    public DbSet<T> Table => _context.Set<T>();

    private readonly AcademyDBContext _context;

    //Gelecekde Constructor Dependency Injection olacaq
    public WriteRepository()
    {
        _context = new AcademyDBContext();
    }

    public void Create(T entity)
    {
        Table.Add(entity);
    }

    public void Delete(T entity)
    {
        Table.Remove(entity);
    }

    public void Update(T entity)
    {
        Table.Update(entity);
    }
}
