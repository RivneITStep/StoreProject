﻿// <auto-generated />
using System;
using Data_Access_Layer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data_Access_Layer.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data_Access_Layer.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Data_Access_Layer.Entities.Store.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int?>("ParentId");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("tblCategories");
                });

            modelBuilder.Entity("Data_Access_Layer.Entities.Store.Filter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FilterNameId")
                        .HasAnnotation("ForeignKey", "FilterNameOf");

                    b.Property<int>("FilterValueId")
                        .HasAnnotation("ForeignKey", "FilterValueOf");

                    b.Property<int>("ProductId")
                        .HasAnnotation("ForeignKey", "ProductOf");

                    b.HasKey("Id");

                    b.HasIndex("FilterNameId");

                    b.HasIndex("FilterValueId");

                    b.HasIndex("ProductId");

                    b.ToTable("tblFilters");
                });

            modelBuilder.Entity("Data_Access_Layer.Entities.Store.FilterName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("tblFilterNames");
                });

            modelBuilder.Entity("Data_Access_Layer.Entities.Store.FilterNameGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FilterNameId")
                        .HasAnnotation("ForeignKey", "FilterNameOf");

                    b.Property<int>("FilterValueId")
                        .HasAnnotation("ForeignKey", "FilterValueOf");

                    b.HasKey("Id");

                    b.HasIndex("FilterNameId");

                    b.HasIndex("FilterValueId");

                    b.ToTable("tblFilterNameGroups");
                });

            modelBuilder.Entity("Data_Access_Layer.Entities.Store.FilterValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("tblFilterValues");
                });

            modelBuilder.Entity("Data_Access_Layer.Entities.Store.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("DATETIME2");

                    b.Property<string>("Description");

                    b.Property<string>("ImagePath");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<float>("Price");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("tblProducts");
                });

            modelBuilder.Entity("Data_Access_Layer.Migrations.Views.Filters.VFilterNameGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FilterName")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("FilterNameId");

                    b.Property<string>("FilterValue")
                        .HasMaxLength(250);

                    b.Property<int?>("FilterValueId");

                    b.HasKey("Id");

                    b.ToTable("vFilterNameGroups");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Data_Access_Layer.Entities.Store.Category", b =>
                {
                    b.HasOne("Data_Access_Layer.Entities.Store.Category")
                        .WithMany("Childrens")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("Data_Access_Layer.Entities.Store.Filter", b =>
                {
                    b.HasOne("Data_Access_Layer.Entities.Store.FilterName", "FilterNameOf")
                        .WithMany("Filters")
                        .HasForeignKey("FilterNameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Data_Access_Layer.Entities.Store.FilterValue", "FilterValueOf")
                        .WithMany("Filters")
                        .HasForeignKey("FilterValueId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Data_Access_Layer.Entities.Store.Product", "ProductOf")
                        .WithMany("Filters")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Data_Access_Layer.Entities.Store.FilterNameGroup", b =>
                {
                    b.HasOne("Data_Access_Layer.Entities.Store.FilterName", "FilterNameOf")
                        .WithMany("FilterNameGroups")
                        .HasForeignKey("FilterNameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Data_Access_Layer.Entities.Store.FilterValue", "FilterValueOf")
                        .WithMany("FilterNameGroups")
                        .HasForeignKey("FilterValueId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Data_Access_Layer.Entities.Store.Product", b =>
                {
                    b.HasOne("Data_Access_Layer.Entities.Store.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Data_Access_Layer.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Data_Access_Layer.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Data_Access_Layer.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Data_Access_Layer.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}