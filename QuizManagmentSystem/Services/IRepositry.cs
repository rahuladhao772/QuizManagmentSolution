using System.Linq.Expressions;

namespace QuizManagmentSystem.Services
{
    public interface IRepositry<T> where T : class
    {
        T GetFirstOrDefault(Expression<Func<T, bool>> expression);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}
