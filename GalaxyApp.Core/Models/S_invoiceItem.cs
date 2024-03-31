using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyApp.Core.Models
{
	[Table("SupplierInvoiceItem")]
	public class S_invoiceItem
	{
		public int Id { get; set; }
		public double Total { get; set; }
		public int Quantity { get; set; }
		public double Purchase_price { get; set; }
		public int ProductId { get; set; }
		public virtual  Product product { get; set; }
		[Column("SupplierInvoiceId")]
		public int S_invoiceId { get; set; }
		public virtual  S_invoice S_Invoice { get; set; }
    }
}
