using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyApp.Core.Models
{
	public class S_invoice
	{
		public int Id { get; set; }
		public DateTime CreationDate { get; set; }
		public double TotalPay { get; set; }
        public int SupplierId { get; set; }
        public virtual Supplier supplier { get; set; }
        public virtual List<S_invoiceItem> S_InvoiceItems { get; set; }
    }
}
