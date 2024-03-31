using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyApp.Core.Dtos
{
	public class Productdto
	{
		public string Name { get; set; }
		public int Low_inventory_In { get; set; }
		public double Evaluation { get; set; }
	}
}
