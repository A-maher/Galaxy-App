 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyApp.Core.Models
{
	public class Supplier
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] National_ID { get; set; }
        public byte[] Photo { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public virtual List<S_invoice> S_Invoices { get; set; }
    }
}
