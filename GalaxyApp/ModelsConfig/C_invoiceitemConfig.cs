using GalaxyApp.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GalaxyApp.Ef.ModelsConfig
{
	public class C_invoiceitemConfig : IEntityTypeConfiguration<C_invoiceItem>
	{
		public void Configure(EntityTypeBuilder<C_invoiceItem> builder)
		{
			builder.ToTable("CustomerInvoiceItems");
			builder.Property(p => p.ProductName).HasMaxLength(50);
			builder.Property(p => p.C_invoiceId).HasColumnName("CustomerInvoiceId");
		}
	}
}
