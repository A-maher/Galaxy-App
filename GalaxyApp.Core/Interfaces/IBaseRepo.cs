using System.Linq.Expressions;

namespace GalaxyApp.Core.Interfaces
{
	public interface IBaseRepo<T> where T : class
	{
		Task<IEnumerable<T>> GetAll();
		Task<T> GetByIdAsync(int id);
		Task<T> FindAsync(Expression<Func<T, bool>> criteria, string[] includes = null);
		Task AddAsync(T entity);
		void Delete(T entity);
	}

}

