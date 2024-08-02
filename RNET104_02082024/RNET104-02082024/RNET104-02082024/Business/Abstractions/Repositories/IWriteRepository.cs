namespace RNET104_02082024.Business.Abstractions.Repositories;

//Create Update Delete => Data Manipulation
public interface IWriteRepository<T>:IRepository<T> where T : class
{
    void Create(T entity);  
    void Update(T entity);
    void Delete(T entity);

}
