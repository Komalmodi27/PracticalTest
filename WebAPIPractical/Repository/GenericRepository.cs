using Microsoft.EntityFrameworkCore;
using WebAPIPractical.Model;

namespace WebAPIPractical.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected DatabaseContext dbcontext;
        internal DbSet<T> entities;

        public GenericRepository(DatabaseContext dbcontext)
        {
            this.dbcontext = dbcontext;
            this.entities = dbcontext.Set<T>();
        }

        public bool Delete(T entity)
        {
            bool flag = false;
            if (entity != null)
            {
                entities.Remove(entity);
                dbcontext.SaveChanges();
                flag = true;
            }
            return flag;
        }

        public IEnumerable<T> GetAll()
        {
            return entities.ToList();
        }

        public T GetById(int Id)
        {
            return entities.Find(Id);
        }

        public bool Insert(T entity)
        {
            bool flag = false;
            if (entity != null)
            {
                entities.Add(entity);
                dbcontext.SaveChanges();
                flag = true;
            }
            return flag;
        }

        public bool Update(T entity)
        {
            bool flag = false;
            if (entity != null)
            {
                entities.Update(entity);
                dbcontext.SaveChanges();
                flag = true;
            }
            return flag;
        }
    }
}
