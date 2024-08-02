using Microsoft.EntityFrameworkCore;
using RNET104_02082024.Models;

namespace RNET104_02082024.Business.Abstractions.Repositories;

public interface IRepository<T> where T : class
{
    DbSet<T> Table { get; }

}
