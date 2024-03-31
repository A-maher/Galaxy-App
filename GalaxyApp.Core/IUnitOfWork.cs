using GalaxyApp.Core.Interfaces;
using GalaxyApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyApp.Core
{
	public interface IUnitOfWork:IDisposable
	{
         IBaseRepo<Supplier> suppliers { get; }
         IBaseRepo<Product> Products { get; }
		Task save();
    }
}
