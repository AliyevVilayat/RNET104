using RNET104_02082024.Models;

namespace RNET104_02082024.Business.Abstractions.Repositories;

public interface IReadRepository<T> : IRepository<T> where T : class
{
    //Read => Select Sorğuları
    T GetById(int id);
    List<T> GetAll();

}
