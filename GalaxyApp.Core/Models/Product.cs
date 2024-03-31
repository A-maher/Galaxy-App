using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyApp.Core.Models
{
	public class Product
	{
        public int Id { get; set; }
        public string Name { get; set; }
		public byte[] Photo { get; set; }
        public int Quantity { get; set; } = 0;
        public int Low_inventory_In{ get; set; }
        public double Evaluation { get; set; }
        public double Purchase_price { get; set; } = 0;
        public double selling_price { get; set; } = 0;
    }
}
