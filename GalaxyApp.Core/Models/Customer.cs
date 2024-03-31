using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyApp.Core.Models
{
	public class Customer
	{
		public int Id { get; set; }
		[MaxLength(50)]
		public string Name { get; set; }
		[MaxLength(11)]
		public string Phone { get; set; }
		public DateTime CreationDate { get; set; }
        public virtual List<C_invoice> C_Invoices { get; set; }
    }
}
