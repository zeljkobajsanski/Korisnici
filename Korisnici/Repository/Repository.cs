using System.Collections.Generic;
using System.Data;
using mvc.com.Korisnici.Model;
using System.Linq;

namespace mvc.com.Korisnici.Repository
{
    public class Repository<T> where T : Entity
    {
        public Repository()
        {
            DataContext = new DataContext();
        }

        public Repository(DataContext dataContext)
        {
            DataContext = dataContext;
        }

        protected DataContext DataContext { get; set; }

        public T Add(T entity)
        {
            DataContext.Set<T>().Add(entity);
            return entity;
        }

        public T Update(T entity)
        {
            DataContext.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public void Delete(T entity)
        {
            DataContext.Entry(entity).State = EntityState.Deleted;
        }

        public T Get(int id)
        {
            return DataContext.Set<T>().SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return DataContext.Set<T>().ToArray();
        } 

        public void Save()
        {
            DataContext.SaveChanges();
        }
    }
}