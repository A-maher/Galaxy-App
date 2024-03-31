using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyApp.Core.Dtos
{
	public class CreateProductdto:Productdto
	{
        public IFormFile Photo { get; set; }

    }
}
