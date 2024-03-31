using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyApp.Core.Dtos
{
	public class SupplierDto
	{
		public string Name { get; set; }
		public IFormFile National_ID { get; set; }
		public IFormFile Photo { get; set; }
	}
}
