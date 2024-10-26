﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sosiska;

#nullable disable

namespace sosiska.Migrations
{
    [DbContext(typeof(MySosiskaContect))]
    partial class MySosiskaContectModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoryWorker", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("WorkersWorkerId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "WorkersWorkerId");

                    b.HasIndex("WorkersWorkerId");

                    b.ToTable("CategoryWorker");
                });

            modelBuilder.Entity("sosiska.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("sosiska.Model.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"));

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("sosiska.Model.Cooker", b =>
                {
                    b.Property<int>("CookerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CookerId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("DishID")
                        .HasColumnType("int");

                    b.Property<int>("WorkerId")
                        .HasColumnType("int");

                    b.HasKey("CookerId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("WorkerId");

                    b.ToTable("Cookers");
                });

            modelBuilder.Entity("sosiska.Model.Dish", b =>
                {
                    b.Property<int>("DishId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DishId"));

                    b.Property<int>("DishCost")
                        .HasColumnType("int");

                    b.Property<string>("DishName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.HasKey("DishId");

                    b.HasIndex("MenuId");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("sosiska.Model.DishComponent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DishId");

                    b.HasIndex("ProductId");

                    b.ToTable("DishComponent");
                });

            modelBuilder.Entity("sosiska.Model.DishOrder", b =>
                {
                    b.Property<int>("DishOrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DishOrderID"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.HasKey("DishOrderID");

                    b.HasIndex("DishId");

                    b.ToTable("DishOrders");
                });

            modelBuilder.Entity("sosiska.Model.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuId"));

                    b.HasKey("MenuId");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("sosiska.Model.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("ClientId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("sosiska.Model.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("NameProduct")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("sosiska.Model.Worker", b =>
                {
                    b.Property<int>("WorkerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkerId"));

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkerId");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("CategoryWorker", b =>
                {
                    b.HasOne("sosiska.Model.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sosiska.Model.Worker", null)
                        .WithMany()
                        .HasForeignKey("WorkersWorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("sosiska.Model.Cooker", b =>
                {
                    b.HasOne("sosiska.Model.Category", "Category")
                        .WithMany("Cookers")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sosiska.Model.Worker", "Worker")
                        .WithMany()
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("sosiska.Model.Dish", b =>
                {
                    b.HasOne("sosiska.Model.Menu", "Menu")
                        .WithMany("Dishes")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("sosiska.Model.DishComponent", b =>
                {
                    b.HasOne("sosiska.Model.Dish", "Dish")
                        .WithMany("DishComponents")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sosiska.Model.Product", "Product")
                        .WithMany("DishComponents")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("sosiska.Model.DishOrder", b =>
                {
                    b.HasOne("sosiska.Model.Dish", "Dish")
                        .WithMany()
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");
                });

            modelBuilder.Entity("sosiska.Model.Order", b =>
                {
                    b.HasOne("sosiska.Model.Client", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("sosiska.Model.Category", b =>
                {
                    b.Navigation("Cookers");
                });

            modelBuilder.Entity("sosiska.Model.Client", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("sosiska.Model.Dish", b =>
                {
                    b.Navigation("DishComponents");
                });

            modelBuilder.Entity("sosiska.Model.Menu", b =>
                {
                    b.Navigation("Dishes");
                });

            modelBuilder.Entity("sosiska.Model.Product", b =>
                {
                    b.Navigation("DishComponents");
                });
#pragma warning restore 612, 618
        }
    }
}
