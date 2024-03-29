﻿// <auto-generated />
using Data_Access_Logic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data_Access_Logic.Migrations
{
    [DbContext(typeof(MMDBContext))]
    [Migration("20211108171304_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LineItemsOrder", b =>
                {
                    b.Property<int>("LineItemsId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("LineItemsId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("LineItemsOrder");
                });

            modelBuilder.Entity("Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("customer_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("address");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("phone_number");

                    b.HasKey("CustomerId");

                    b.HasIndex(new[] { "Email" }, "UQ__customer__AB6E61642D925A68")
                        .IsUnique();

                    b.ToTable("customer");
                });

            modelBuilder.Entity("Models.LineItems", b =>
                {
                    b.Property<int>("LineItemsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("line_item_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<int>("StoreFrontId")
                        .HasColumnType("int")
                        .HasColumnName("storefront_id");

                    b.HasKey("LineItemsId");

                    b.HasIndex("ProductId");

                    b.HasIndex("StoreFrontId");

                    b.ToTable("line_item");
                });

            modelBuilder.Entity("Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("order_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("address");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("customer_id");

                    b.Property<int>("StoreFrontId")
                        .HasColumnType("int")
                        .HasColumnName("storefront_id");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,0)")
                        .HasColumnName("total_price");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("StoreFrontId");

                    b.ToTable("order_");
                });

            modelBuilder.Entity("Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("product_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("brand");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("category");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(750)
                        .IsUnicode(false)
                        .HasColumnType("varchar(750)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("price");

                    b.HasKey("ProductId");

                    b.ToTable("product");
                });

            modelBuilder.Entity("Models.StoreFront", b =>
                {
                    b.Property<int>("StoreFrontId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("storefront_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("address");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("StoreFrontId");

                    b.ToTable("storefront");
                });

            modelBuilder.Entity("LineItemsOrder", b =>
                {
                    b.HasOne("Models.LineItems", null)
                        .WithMany()
                        .HasForeignKey("LineItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Order", null)
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.LineItems", b =>
                {
                    b.HasOne("Models.Product", "Product")
                        .WithMany("LineItems")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK__line_item__produ__160F4887")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.StoreFront", "StoreFront")
                        .WithMany("LineItems")
                        .HasForeignKey("StoreFrontId")
                        .HasConstraintName("FK__line_item__store__17036CC0")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("StoreFront");
                });

            modelBuilder.Entity("Models.Order", b =>
                {
                    b.HasOne("Models.Customer", "Customer")
                        .WithMany("Order")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("order__FK")
                        .IsRequired();

                    b.HasOne("Models.StoreFront", "StoreFront")
                        .WithMany("Order")
                        .HasForeignKey("StoreFrontId")
                        .HasConstraintName("FK__order___storefro__1332DBDC")
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("StoreFront");
                });

            modelBuilder.Entity("Models.Customer", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("Models.Product", b =>
                {
                    b.Navigation("LineItems");
                });

            modelBuilder.Entity("Models.StoreFront", b =>
                {
                    b.Navigation("LineItems");

                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}
