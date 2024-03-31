using GalaxyApp.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GalaxyApp.Ef.ModelsConfig
{
	public class C_invoiceConfig : IEntityTypeConfiguration<C_invoice>
	{
		public void Configure(EntityTypeBuilder<C_invoice> builder)
		{
			builder.ToTable("CustomerInvoices");
		}
	}
}
