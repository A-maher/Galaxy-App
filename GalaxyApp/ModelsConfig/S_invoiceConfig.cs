using GalaxyApp.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyApp.Ef.ModelsConfig
{
	internal class S_invoiceConfig : IEntityTypeConfiguration<S_invoice>
	{
		void IEntityTypeConfiguration<S_invoice>.Configure(EntityTypeBuilder<S_invoice> builder)
		{
			builder.ToTable("SupplierInvoice");
		}
	}
}
