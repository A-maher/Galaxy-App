using GalaxyApp.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GalaxyApp.Ef.ModelsConfig
{
	public class ProductConfig : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.HasIndex(p => p.Name).IsUnique();
			builder.ToTable("Puroducts");
			builder.Property(p => p.Name).HasMaxLength(50);
		}
	}
}
