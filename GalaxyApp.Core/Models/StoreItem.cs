using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyApp.Core.Models
{
	public class StoreItem
	{
        public int Id { get; set; }
        public bool InStore { get; set; }
        public DateTime CreationDate { get; set; }
        public string BarCode { get; set; }
		public int ProductId { get; set; }
		public virtual Product product { get; set; }
	}
}
