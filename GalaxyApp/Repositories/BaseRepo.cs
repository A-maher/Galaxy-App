using GalaxyApp.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyApp.Ef.Repositories
{
	public class BaseRepo<T> : IBaseRepo<T> where T : class
	{
		protected AppDBContext _context;

		public BaseRepo(AppDBContext context)
		{
			_context = context;
		}
		
		public async Task AddAsync(T entity)
		{
			await _context.Set<T>().AddAsync(entity);
		}

		public void  Delete(T entity)
		{
			_context.Set<T>().Remove(entity);
		}

		public async Task<T> FindAsync(Expression<Func<T, bool>> criteria, string[] includes = null)
		{
			IQueryable<T> query = _context.Set<T>();
			if (includes != null)
				foreach( var Includ in includes)
				query= query.Include(Includ);
			return await query.SingleOrDefaultAsync(criteria);
		}

		public async Task<IEnumerable<T>> GetAll()
		{
			return await _context.Set<T>().ToListAsync();
		}

		public async Task<T> GetByIdAsync(int id)
		{
			return await _context.Set<T>().FindAsync(id);
		}

	}
}
