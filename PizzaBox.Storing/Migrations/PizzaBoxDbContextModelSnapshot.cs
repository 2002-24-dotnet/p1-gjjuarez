﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaBox.Storing.Databases;

namespace PizzaBox.Storing.Migrations
{
    [DbContext(typeof(PizzaBoxDbContext))]
    partial class PizzaBoxDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzaBox.Domain.Models.Crust", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Crust");

                    b.HasData(
                        new
                        {
                            Id = 637205848995357348L,
                            Name = "Stuffed Crust",
                            Price = 3.00m
                        },
                        new
                        {
                            Id = 637205848995394045L,
                            Name = "Hand Tossed",
                            Price = 1.00m
                        },
                        new
                        {
                            Id = 637205848995394157L,
                            Name = "Deep Dish",
                            Price = 2.00m
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<long?>("StoreId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("TimeOrdered")
                        .HasColumnType("datetime2");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Pizza", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<long?>("CrustId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<long?>("SizeId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CrustId");

                    b.HasIndex("OrderId");

                    b.HasIndex("SizeId");

                    b.ToTable("Pizza");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.PizzaTopping", b =>
                {
                    b.Property<long>("PizzaId")
                        .HasColumnType("bigint");

                    b.Property<long>("ToppingId")
                        .HasColumnType("bigint");

                    b.HasKey("PizzaId", "ToppingId");

                    b.HasIndex("ToppingId");

                    b.ToTable("PizzaTopping");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Size", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Size");

                    b.HasData(
                        new
                        {
                            Id = 637205848995423416L,
                            Name = "Large",
                            Price = 17.95m
                        },
                        new
                        {
                            Id = 637205848995424190L,
                            Name = "Regular",
                            Price = 12.95m
                        },
                        new
                        {
                            Id = 637205848995424240L,
                            Name = "Small",
                            Price = 9.95m
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Store", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Store");

                    b.HasData(
                        new
                        {
                            Id = 637205848995434103L,
                            Address = "12345 Streat st, Arlington, Texas",
                            Name = "Dominos",
                            Password = "Password1",
                            Username = "store1"
                        },
                        new
                        {
                            Id = 637205848995435302L,
                            Address = "12346 Streat st, Arlington, Texas",
                            Name = "Papa Johns",
                            Password = "Password2",
                            Username = "store2"
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Topping", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ToppingType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Topping");

                    b.HasData(
                        new
                        {
                            Id = 637205848995425662L,
                            Name = "Mozzarella Cheese",
                            Price = 0.25m,
                            ToppingType = 0
                        },
                        new
                        {
                            Id = 637205848995426255L,
                            Name = "Parmesan Cheese",
                            Price = 0.50m,
                            ToppingType = 0
                        },
                        new
                        {
                            Id = 637205848995426332L,
                            Name = "Tomato Sauce",
                            Price = 0.25m,
                            ToppingType = 1
                        },
                        new
                        {
                            Id = 637205848995426338L,
                            Name = "Pepperoni",
                            Price = 1.00m,
                            ToppingType = 2
                        },
                        new
                        {
                            Id = 637205848995426350L,
                            Name = "Ham",
                            Price = 1.50m,
                            ToppingType = 2
                        },
                        new
                        {
                            Id = 637205848995426361L,
                            Name = "Beef",
                            Price = 1.50m,
                            ToppingType = 2
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 637205848995430188L,
                            Name = "George",
                            Password = "Password12345",
                            Username = "George"
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Store", "Store")
                        .WithMany("Orders")
                        .HasForeignKey("StoreId");

                    b.HasOne("PizzaBox.Domain.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Pizza", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Crust", "Crust")
                        .WithMany("Pizzas")
                        .HasForeignKey("CrustId");

                    b.HasOne("PizzaBox.Domain.Models.Order", "Order")
                        .WithMany("Pizzas")
                        .HasForeignKey("OrderId");

                    b.HasOne("PizzaBox.Domain.Models.Size", "Size")
                        .WithMany("Pizzas")
                        .HasForeignKey("SizeId");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.PizzaTopping", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Pizza", "Pizza")
                        .WithMany("PizzaToppings")
                        .HasForeignKey("PizzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaBox.Domain.Models.Topping", "Topping")
                        .WithMany("PizzaToppings")
                        .HasForeignKey("ToppingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
