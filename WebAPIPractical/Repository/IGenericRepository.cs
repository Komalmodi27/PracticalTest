namespace WebAPIPractical.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T GetById(int Id);

        bool Insert(T entity);

        bool Update(T entity);

        bool Delete(T entity);

    }
}
