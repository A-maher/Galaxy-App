using GalaxyApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyApp.Core.Models
{
	public class C_invoice
	{
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public double TotalPay { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual List<C_invoiceItem> C_InvoiceItems { get; set; }


    }
}