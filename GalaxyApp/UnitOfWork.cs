using GalaxyApp.Core;
using GalaxyApp.Core.Interfaces;
using GalaxyApp.Core.Models;
using GalaxyApp.Ef.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyApp.Ef
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly AppDBContext _context;
        public IBaseRepo<Supplier> suppliers { get; private set; }
        public IBaseRepo<Product> Products { get; private set; }
        public UnitOfWork(AppDBContext context)
        {
			_context = context;
			Products = new BaseRepo<Product>(_context);
		}
        public void Dispose()
		{
			_context.Dispose();
		}

		public Task  save()
		{
			return _context.SaveChangesAsync();
		}
	}
}
