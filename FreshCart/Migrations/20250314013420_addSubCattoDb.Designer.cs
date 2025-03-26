﻿// <auto-generated />
using System;
using FreshCart.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FreshCart.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250314013420_addSubCattoDb")]
    partial class addSubCattoDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BrandCategory", b =>
                {
                    b.Property<Guid>("BrandsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoriesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BrandsId", "CategoriesId");

                    b.HasIndex("CategoriesId");

                    b.ToTable("BrandCategory");
                });

            modelBuilder.Entity("BrandSubCategory", b =>
                {
                    b.Property<Guid>("BrandsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubCategoriesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BrandsId", "SubCategoriesId");

                    b.HasIndex("SubCategoriesId");

                    b.ToTable("BrandSubCategory");
                });

            modelBuilder.Entity("FreshCart.Models.Domain.Brand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("FreshCart.Models.Domain.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7bbb9a6e-27f2-49ca-a62a-59f04c940090"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3290),
                            ImageUrl = "https://ecommerce.routemisr.com/Route-Academy-categories/1681511964020.jpeg",
                            Name = "Music",
                            Slug = "music",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3297)
                        },
                        new
                        {
                            Id = new Guid("40d9125c-01b3-4084-b60f-2a4fee924765"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3301),
                            ImageUrl = "https://ecommerce.routemisr.com/Route-Academy-categories/1681511865180.jpeg",
                            Name = "Men's Fashion",
                            Slug = "men's-fashion",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3301)
                        },
                        new
                        {
                            Id = new Guid("046a4dd7-9529-4de1-bcd9-25e1f188577d"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3304),
                            ImageUrl = "https://ecommerce.routemisr.com/Route-Academy-categories/1681511818071.jpeg",
                            Name = "Women's Fashion",
                            Slug = "women's-fashion",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3304)
                        },
                        new
                        {
                            Id = new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3307),
                            ImageUrl = "https://ecommerce.routemisr.com/Route-Academy-categories/1681511452254.png",
                            Name = "SuperMarket",
                            Slug = "supermarket",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3307)
                        },
                        new
                        {
                            Id = new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3309),
                            ImageUrl = "https://ecommerce.routemisr.com/Route-Academy-categories/1681511427130.png",
                            Name = "Baby & Toys",
                            Slug = "baby-and-toys",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3310)
                        },
                        new
                        {
                            Id = new Guid("67f73162-8eff-43fe-b693-3951a800b20d"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3312),
                            ImageUrl = "https://ecommerce.routemisr.com/Route-Academy-categories/1681511392672.png",
                            Name = "Home",
                            Slug = "home",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3312)
                        },
                        new
                        {
                            Id = new Guid("b39860b5-91b7-41dd-b52b-22d2ee9c4ec4"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3314),
                            ImageUrl = "https://ecommerce.routemisr.com/Route-Academy-categories/1681511368164.png",
                            Name = "Books",
                            Slug = "books",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3315)
                        },
                        new
                        {
                            Id = new Guid("41c1d6bf-035b-490d-a5a5-80990a61ac32"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3317),
                            ImageUrl = "https://ecommerce.routemisr.com/Route-Academy-categories/1681511179514.png",
                            Name = "Beauty & Health",
                            Slug = "beauty-and-health",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3317)
                        },
                        new
                        {
                            Id = new Guid("716b7818-280f-4c6d-b221-010b314d6929"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3319),
                            ImageUrl = "https://ecommerce.routemisr.com/Route-Academy-categories/1681511156008.png",
                            Name = "Mobiles",
                            Slug = "mobiles",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3320)
                        },
                        new
                        {
                            Id = new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3321),
                            ImageUrl = "https://ecommerce.routemisr.com/Route-Academy-categories/1681511121316.png",
                            Name = "Electronics",
                            Slug = "electronics",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3322)
                        });
                });

            modelBuilder.Entity("FreshCart.Models.Domain.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BrandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageCoverUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagesUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("RatingsAverage")
                        .HasColumnType("float");

                    b.Property<int>("RatingsQuantity")
                        .HasColumnType("int");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Sold")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("FreshCart.Models.Domain.SubCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("SubCategories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("637315cb-516d-4dd8-9a8f-d7664de2e260"),
                            CategoryId = new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3547),
                            Name = "Diapers & Diaper Bags",
                            Slug = "diapers-and-diaper-bags",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3547)
                        },
                        new
                        {
                            Id = new Guid("d130d3ef-7988-4cd9-be5b-2746e9b2af93"),
                            CategoryId = new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3551),
                            Name = "Baby Safety Products",
                            Slug = "baby-safety-products",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3552)
                        },
                        new
                        {
                            Id = new Guid("b51ede19-8fb6-4605-92d5-fcbdeb71312e"),
                            CategoryId = new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3565),
                            Name = "Pet Supplies",
                            Slug = "pet-supplies",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3565)
                        },
                        new
                        {
                            Id = new Guid("d2b1aa2f-6d3e-4c09-8ee2-efd0efc92f44"),
                            CategoryId = new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3568),
                            Name = "Candy & Chocolate",
                            Slug = "candy-and-chocolate",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3569)
                        },
                        new
                        {
                            Id = new Guid("679a4e5d-7964-4552-862c-584c24e57a5d"),
                            CategoryId = new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3571),
                            Name = "Baby Food",
                            Slug = "baby-food",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3572)
                        },
                        new
                        {
                            Id = new Guid("662b0a59-0c42-4dfa-89a3-039537a59f57"),
                            CategoryId = new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3575),
                            Name = "Breakfast Food",
                            Slug = "breakfast-food",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3575)
                        },
                        new
                        {
                            Id = new Guid("3f3e77e6-270b-464d-b4dd-8896ab15c09a"),
                            CategoryId = new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3578),
                            Name = "Snack Food",
                            Slug = "snack-food",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3578)
                        },
                        new
                        {
                            Id = new Guid("9698f6ab-e4e5-49bb-ab64-e7280276b9f0"),
                            CategoryId = new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3581),
                            Name = "Home Care & Cleaning",
                            Slug = "home-care-and-cleaning",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3581)
                        },
                        new
                        {
                            Id = new Guid("cd9bd982-a127-40ad-afd2-0379000ad06b"),
                            CategoryId = new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3584),
                            Name = "Beverages",
                            Slug = "beverages",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3584)
                        },
                        new
                        {
                            Id = new Guid("e7235a2d-9aef-4392-95a2-3255fd00c192"),
                            CategoryId = new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3587),
                            Name = "Canned Dry and Packaged Foods",
                            Slug = "canned-dry-and-packaged-foods",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3587)
                        },
                        new
                        {
                            Id = new Guid("35c94c09-9fab-4a70-90b5-36c81f832cf8"),
                            CategoryId = new Guid("41c1d6bf-035b-490d-a5a5-80990a61ac32"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3593),
                            Name = "Skin Care",
                            Slug = "skin-care",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3593)
                        },
                        new
                        {
                            Id = new Guid("edde2438-ec31-43de-b181-9f9e07ae8ab9"),
                            CategoryId = new Guid("41c1d6bf-035b-490d-a5a5-80990a61ac32"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3596),
                            Name = "Hair Care",
                            Slug = "hair-care",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3596)
                        },
                        new
                        {
                            Id = new Guid("05b68f1b-2f82-4a67-b7f9-dbd929715711"),
                            CategoryId = new Guid("41c1d6bf-035b-490d-a5a5-80990a61ac32"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3599),
                            Name = "Makeup",
                            Slug = "makeup",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3600)
                        },
                        new
                        {
                            Id = new Guid("d09ee4f2-be92-4704-98d4-16bf800909f9"),
                            CategoryId = new Guid("41c1d6bf-035b-490d-a5a5-80990a61ac32"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3602),
                            Name = "Fragrance",
                            Slug = "fragrance",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3603)
                        },
                        new
                        {
                            Id = new Guid("bd51ef41-bc6b-416c-a10c-f9f493e3e76f"),
                            CategoryId = new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3606),
                            Name = "Toys",
                            Slug = "toys",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3606)
                        },
                        new
                        {
                            Id = new Guid("d4b855eb-234b-4f8f-a14c-9f516493df1d"),
                            CategoryId = new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3609),
                            Name = "Potty Training",
                            Slug = "potty-training",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3609)
                        },
                        new
                        {
                            Id = new Guid("8f2225a4-86e5-46e0-8711-d18a9414bf91"),
                            CategoryId = new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3612),
                            Name = "Bouncers & Swings",
                            Slug = "bouncers-and-swings",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3612)
                        },
                        new
                        {
                            Id = new Guid("1f066d73-4259-403d-97c7-4f8173f7c472"),
                            CategoryId = new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3615),
                            Name = "Car Seats & Strollers",
                            Slug = "car-seats-and-strollers",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3616)
                        },
                        new
                        {
                            Id = new Guid("910240a7-ac53-480f-b80e-bd9343e8c6bf"),
                            CategoryId = new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3621),
                            Name = "Nursing & Feeding",
                            Slug = "nursing-and-feeding",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3621)
                        },
                        new
                        {
                            Id = new Guid("1d9471ee-042a-4f5a-a88f-a1a999dc5e2d"),
                            CategoryId = new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3624),
                            Name = "Bathing & Skin Care",
                            Slug = "bathing-and-skin-care",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3624)
                        },
                        new
                        {
                            Id = new Guid("d128b45b-75b1-45af-86d5-eec73e17a9cc"),
                            CategoryId = new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3627),
                            Name = "Computer Accessories",
                            Slug = "computer-accessories",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3627)
                        },
                        new
                        {
                            Id = new Guid("a7702ae4-d228-46b3-97b6-a24cac9700e1"),
                            CategoryId = new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3630),
                            Name = "Computer Components",
                            Slug = "computer-components",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3630)
                        },
                        new
                        {
                            Id = new Guid("0883a5f0-5e11-407c-8d0a-6a4aed08f950"),
                            CategoryId = new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3633),
                            Name = "Data Storage",
                            Slug = "data-storage",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3633)
                        },
                        new
                        {
                            Id = new Guid("ea5f83d5-317a-4302-8141-753bafcb5de4"),
                            CategoryId = new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3636),
                            Name = "Networking Products",
                            Slug = "networking-products",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3636)
                        },
                        new
                        {
                            Id = new Guid("916f85b4-7d93-4015-a65d-c0d4d29ea4f1"),
                            CategoryId = new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3639),
                            Name = "Printers & Accessories",
                            Slug = "printers-and-accessories",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3639)
                        },
                        new
                        {
                            Id = new Guid("46c2f155-b8ba-4785-9ca9-50065a86b2de"),
                            CategoryId = new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3642),
                            Name = "Cameras & Accessories",
                            Slug = "cameras-and-accessories",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3642)
                        },
                        new
                        {
                            Id = new Guid("cc34e47d-a056-4a07-805e-10131e83ed82"),
                            CategoryId = new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3647),
                            Name = "Video Games",
                            Slug = "video-games",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3647)
                        },
                        new
                        {
                            Id = new Guid("081af716-b1a1-40e0-aae3-3ef7133452e6"),
                            CategoryId = new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3650),
                            Name = "Audio & Home Entertainment",
                            Slug = "audio-and-home-entertainment",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3650)
                        },
                        new
                        {
                            Id = new Guid("21ad8aaf-77fa-4659-bde9-49999dc883ca"),
                            CategoryId = new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3653),
                            Name = "Laptops & Accessories",
                            Slug = "laptops-and-accessories",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3653)
                        },
                        new
                        {
                            Id = new Guid("44322ad4-8c7a-4d6f-9ea1-3bb52f56a966"),
                            CategoryId = new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"),
                            CreatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3656),
                            Name = "TVs, Satellites & Accessories",
                            Slug = "tvs-satellites-and-accessories",
                            UpdatedAt = new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3656)
                        });
                });

            modelBuilder.Entity("BrandCategory", b =>
                {
                    b.HasOne("FreshCart.Models.Domain.Brand", null)
                        .WithMany()
                        .HasForeignKey("BrandsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FreshCart.Models.Domain.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BrandSubCategory", b =>
                {
                    b.HasOne("FreshCart.Models.Domain.Brand", null)
                        .WithMany()
                        .HasForeignKey("BrandsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FreshCart.Models.Domain.SubCategory", null)
                        .WithMany()
                        .HasForeignKey("SubCategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FreshCart.Models.Domain.Product", b =>
                {
                    b.HasOne("FreshCart.Models.Domain.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FreshCart.Models.Domain.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("FreshCart.Models.Domain.SubCategory", b =>
                {
                    b.HasOne("FreshCart.Models.Domain.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FreshCart.Models.Domain.Product", null)
                        .WithMany("SubCategories")
                        .HasForeignKey("ProductId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("FreshCart.Models.Domain.Category", b =>
                {
                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("FreshCart.Models.Domain.Product", b =>
                {
                    b.Navigation("SubCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
