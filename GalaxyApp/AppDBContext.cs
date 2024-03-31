using GalaxyApp.Core.Models;
using GalaxyApp.Ef.ModelsConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyApp.Ef
{
	public class AppDBContext:DbContext
	{
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {
        }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductConfig).Assembly);
		}
		public virtual DbSet<Product> Products { get; set; }
		public virtual DbSet<Supplier> Suppliers { get; set; }
		public virtual DbSet<S_invoice> S_Invoices { get; set; }
		public virtual DbSet<S_invoiceItem> S_InvoiceItems { get; set; }
		public virtual DbSet<StoreItem> StoreItems { get; set; }
		public virtual DbSet<Customer> Customers { get; set; }
		public virtual DbSet<C_invoice> C_Invoices { get; set; }
		public virtual DbSet<C_invoiceItem> C_InvoiceItems { get; set; }

	}
}
