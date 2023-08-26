using Microsoft.EntityFrameworkCore;
using QuizManagmentSystem.DataContext;
using System.Linq.Expressions;

namespace QuizManagmentSystem.Services.Repositries
{
    public class Repositry<T> : IRepositry<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> _dbset;
        public Repositry(ApplicationDbContext db)
        {
                _db = db;
            this._dbset=_db.Set<T>();
        }
        public void Add(T entity)
        {
            _dbset.Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
           IQueryable<T> entity=_dbset;
            return entity.ToList();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> expression)
        {
            T? result = _dbset.FirstOrDefault(expression);
            if (result == null)
            {
                return null;
            }
            return result;

            //IQueryable<T> query = _dbset;
            //query=query.Where(expression);
            //return query.FirstOrDefault();
        }

        public void Remove(T entity)
        {
            _dbset.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            _dbset.RemoveRange(entity); 
        }
    }
}
