using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyApp.Core.Dtos
{
	public class ProdctIDdto:Productdto
	{
		public int Id { get; set; }
		public byte[] Photo { get; set; }

	}
}
