using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyApp.Core.Models
{
    public class C_invoiceItem
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductId { get; set; }
        public virtual Product product { get; set; }
        public int C_invoiceId { get; set; }
        public virtual C_invoice C_Invoice { get; set; }

    }
}
