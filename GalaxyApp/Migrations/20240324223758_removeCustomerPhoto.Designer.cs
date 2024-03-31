﻿// <auto-generated />
using System;
using GalaxyApp.Ef;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GalaxyApp.Ef.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20240324223758_removeCustomerPhoto")]
    partial class removeCustomerPhoto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GalaxyApp.Core.Models.C_invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<double>("TotalPay")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerInvoices", (string)null);
                });

            modelBuilder.Entity("GalaxyApp.Core.Models.C_invoiceItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("C_invoiceId")
                        .HasColumnType("int")
                        .HasColumnName("CustomerInvoiceId");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("ProductPrice")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("C_invoiceId");

                    b.HasIndex("ProductId");

                    b.ToTable("CustomerInvoiceItems", (string)null);
                });

            modelBuilder.Entity("GalaxyApp.Core.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("GalaxyApp.Core.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Evaluation")
                        .HasColumnType("float");

                    b.Property<int>("Low_inventory_In")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("Photo")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<double>("Purchase_price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("selling_price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Puroducts", (string)null);
                });

            modelBuilder.Entity("GalaxyApp.Core.Models.S_invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<double>("TotalPay")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("SupplierId");

                    b.ToTable("SupplierInvoice", (string)null);
                });

            modelBuilder.Entity("GalaxyApp.Core.Models.S_invoiceItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<double>("Purchase_price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("S_invoiceId")
                        .HasColumnType("int")
                        .HasColumnName("SupplierInvoiceId");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("S_invoiceId");

                    b.ToTable("SupplierInvoiceItem");
                });

            modelBuilder.Entity("GalaxyApp.Core.Models.StoreItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BarCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("InStore")
                        .HasColumnType("bit");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("StoreItems");
                });

            modelBuilder.Entity("GalaxyApp.Core.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("National_ID")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Photo")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("GalaxyApp.Core.Models.C_invoice", b =>
                {
                    b.HasOne("GalaxyApp.Core.Models.Customer", "Customer")
                        .WithMany("C_Invoices")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("GalaxyApp.Core.Models.C_invoiceItem", b =>
                {
                    b.HasOne("GalaxyApp.Core.Models.C_invoice", "C_Invoice")
                        .WithMany("C_InvoiceItems")
                        .HasForeignKey("C_invoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GalaxyApp.Core.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("C_Invoice");

                    b.Navigation("product");
                });

            modelBuilder.Entity("GalaxyApp.Core.Models.S_invoice", b =>
                {
                    b.HasOne("GalaxyApp.Core.Models.Supplier", "supplier")
                        .WithMany("S_Invoices")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("supplier");
                });

            modelBuilder.Entity("GalaxyApp.Core.Models.S_invoiceItem", b =>
                {
                    b.HasOne("GalaxyApp.Core.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GalaxyApp.Core.Models.S_invoice", "S_Invoice")
                        .WithMany("S_InvoiceItems")
                        .HasForeignKey("S_invoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("S_Invoice");

                    b.Navigation("product");
                });

            modelBuilder.Entity("GalaxyApp.Core.Models.StoreItem", b =>
                {
                    b.HasOne("GalaxyApp.Core.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");
                });

            modelBuilder.Entity("GalaxyApp.Core.Models.C_invoice", b =>
                {
                    b.Navigation("C_InvoiceItems");
                });

            modelBuilder.Entity("GalaxyApp.Core.Models.Customer", b =>
                {
                    b.Navigation("C_Invoices");
                });

            modelBuilder.Entity("GalaxyApp.Core.Models.S_invoice", b =>
                {
                    b.Navigation("S_InvoiceItems");
                });

            modelBuilder.Entity("GalaxyApp.Core.Models.Supplier", b =>
                {
                    b.Navigation("S_Invoices");
                });
#pragma warning restore 612, 618
        }
    }
}
