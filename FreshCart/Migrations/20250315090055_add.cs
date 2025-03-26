using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FreshCart.Migrations
{
    /// <inheritdoc />
    public partial class add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "ImageUrl", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("046a4dd7-9529-4de1-bcd9-25e1f188577d"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7557), "https://ecommerce.routemisr.com/Route-Academy-categories/1681511818071.jpeg", "Women's Fashion", "women's-fashion", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7558) },
                    { new Guid("40d9125c-01b3-4084-b60f-2a4fee924765"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7555), "https://ecommerce.routemisr.com/Route-Academy-categories/1681511865180.jpeg", "Men's Fashion", "men's-fashion", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7555) },
                    { new Guid("41c1d6bf-035b-490d-a5a5-80990a61ac32"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7570), "https://ecommerce.routemisr.com/Route-Academy-categories/1681511179514.png", "Beauty & Health", "beauty-and-health", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7571) },
                    { new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7560), "https://ecommerce.routemisr.com/Route-Academy-categories/1681511452254.png", "SuperMarket", "supermarket", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7561) },
                    { new Guid("67f73162-8eff-43fe-b693-3951a800b20d"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7566), "https://ecommerce.routemisr.com/Route-Academy-categories/1681511392672.png", "Home", "home", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7567) },
                    { new Guid("716b7818-280f-4c6d-b221-010b314d6929"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7572), "https://ecommerce.routemisr.com/Route-Academy-categories/1681511156008.png", "Mobiles", "mobiles", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7573) },
                    { new Guid("7bbb9a6e-27f2-49ca-a62a-59f04c940090"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7549), "https://ecommerce.routemisr.com/Route-Academy-categories/1681511964020.jpeg", "Music", "music", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7551) },
                    { new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7574), "https://ecommerce.routemisr.com/Route-Academy-categories/1681511121316.png", "Electronics", "electronics", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7575) },
                    { new Guid("b39860b5-91b7-41dd-b52b-22d2ee9c4ec4"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7568), "https://ecommerce.routemisr.com/Route-Academy-categories/1681511368164.png", "Books", "books", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7569) },
                    { new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7564), "https://ecommerce.routemisr.com/Route-Academy-categories/1681511427130.png", "Baby & Toys", "baby-and-toys", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7564) }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("099c3527-c996-4cb1-9b15-926f6959db9c"), new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7790), "Printers & Accessories", "printers-and-accessories", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7790) },
                    { new Guid("0e7a1aa5-de2c-4d01-82fd-fea5feffbecf"), new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7746), "Beverages", "beverages", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7746) },
                    { new Guid("10363adb-1dbc-4afe-87d5-f7052470433e"), new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7768), "Bouncers & Swings", "bouncers-and-swings", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7768) },
                    { new Guid("128d789a-4c9b-4fb8-bf67-4d0f86d247ae"), new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7783), "Computer Components", "computer-components", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7783) },
                    { new Guid("1755a2f5-20c2-4d82-b8ea-b572c5eb3fa6"), new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7799), "Audio & Home Entertainment", "audio-and-home-entertainment", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7800) },
                    { new Guid("254379ac-5f27-4916-a992-b20cbf21fac3"), new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7731), "Pet Supplies", "pet-supplies", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7732) },
                    { new Guid("2ee5fd43-4f76-4252-a29f-2e07b0718a80"), new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7770), "Car Seats & Strollers", "car-seats-and-strollers", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7771) },
                    { new Guid("3c28ad1b-697d-42e9-a05a-83257a3b4c5f"), new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7877), "Laptops & Accessories", "laptops-and-accessories", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7878) },
                    { new Guid("4571f58d-dff6-4f1a-b02f-4e8c4dccc226"), new Guid("41c1d6bf-035b-490d-a5a5-80990a61ac32"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7756), "Hair Care", "hair-care", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7756) },
                    { new Guid("4ff2068f-6394-41b6-8228-915f0db26e24"), new Guid("41c1d6bf-035b-490d-a5a5-80990a61ac32"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7758), "Makeup", "makeup", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7759) },
                    { new Guid("62771190-e326-429f-b253-b7112db8e28d"), new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7749), "Canned Dry and Packaged Foods", "canned-dry-and-packaged-foods", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7749) },
                    { new Guid("66d54eb1-64bd-45f9-b2cc-db1d575fd570"), new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7778), "Bathing & Skin Care", "bathing-and-skin-care", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7778) },
                    { new Guid("72c79f91-ac64-4ff6-a14b-ad779fb8cdab"), new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7744), "Home Care & Cleaning", "home-care-and-cleaning", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7744) },
                    { new Guid("75e59689-9d18-414d-9037-f5177b0de36f"), new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7741), "Snack Food", "snack-food", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7742) },
                    { new Guid("78e2f979-426e-404b-aaba-4d7d6e603132"), new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7716), "Diapers & Diaper Bags", "diapers-and-diaper-bags", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7716) },
                    { new Guid("794b185b-ce0c-4c93-a947-15091e9ed979"), new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7775), "Nursing & Feeding", "nursing-and-feeding", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7776) },
                    { new Guid("937ab0cd-20d9-4458-b648-49675d9deed7"), new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7880), "TVs, Satellites & Accessories", "tvs-satellites-and-accessories", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7880) },
                    { new Guid("995415ec-f9d9-4a2c-9283-8b0168db14fd"), new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7797), "Video Games", "video-games", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7797) },
                    { new Guid("9c30614a-4849-4463-81b0-284b90a84741"), new Guid("41c1d6bf-035b-490d-a5a5-80990a61ac32"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7761), "Fragrance", "fragrance", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7761) },
                    { new Guid("9fff2ac6-e92b-4565-8149-8df5f1fe6bd2"), new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7763), "Toys", "toys", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7763) },
                    { new Guid("ab7f04c3-2f88-46c5-a218-055f7e9a9325"), new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7720), "Baby Safety Products", "baby-safety-products", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7720) },
                    { new Guid("abc2c203-fcb7-497d-bc8c-54f83cdfb93f"), new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7734), "Candy & Chocolate", "candy-and-chocolate", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7734) },
                    { new Guid("b377ed23-ed9d-4072-84e2-9f2e7dc06f8f"), new Guid("41c1d6bf-035b-490d-a5a5-80990a61ac32"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7753), "Skin Care", "skin-care", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7754) },
                    { new Guid("bd11ab09-6c84-4077-905a-6f2f53255e6c"), new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7792), "Cameras & Accessories", "cameras-and-accessories", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7792) },
                    { new Guid("c75f021e-f2a3-47b9-9956-590b686bb12a"), new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7785), "Data Storage", "data-storage", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7785) },
                    { new Guid("d6a53f44-56a6-4ec2-ba83-3995cc592b09"), new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7765), "Potty Training", "potty-training", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7766) },
                    { new Guid("ea1655d6-fc27-4dde-819b-f420d64285fe"), new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7736), "Baby Food", "baby-food", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7737) },
                    { new Guid("f40f6b52-2ff5-4a37-bd67-1ad00f2e29a5"), new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7780), "Computer Accessories", "computer-accessories", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7781) },
                    { new Guid("f43c48dc-ea73-450f-8255-92d20ff88576"), new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7787), "Networking Products", "networking-products", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7788) },
                    { new Guid("ffb35f56-8700-4750-bb1b-1647e1f3ad22"), new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"), new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7739), "Breakfast Food", "breakfast-food", new DateTime(2025, 3, 15, 9, 0, 55, 264, DateTimeKind.Utc).AddTicks(7739) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("046a4dd7-9529-4de1-bcd9-25e1f188577d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("40d9125c-01b3-4084-b60f-2a4fee924765"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("67f73162-8eff-43fe-b693-3951a800b20d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("716b7818-280f-4c6d-b221-010b314d6929"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7bbb9a6e-27f2-49ca-a62a-59f04c940090"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b39860b5-91b7-41dd-b52b-22d2ee9c4ec4"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("099c3527-c996-4cb1-9b15-926f6959db9c"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("0e7a1aa5-de2c-4d01-82fd-fea5feffbecf"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("10363adb-1dbc-4afe-87d5-f7052470433e"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("128d789a-4c9b-4fb8-bf67-4d0f86d247ae"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("1755a2f5-20c2-4d82-b8ea-b572c5eb3fa6"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("254379ac-5f27-4916-a992-b20cbf21fac3"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("2ee5fd43-4f76-4252-a29f-2e07b0718a80"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3c28ad1b-697d-42e9-a05a-83257a3b4c5f"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("4571f58d-dff6-4f1a-b02f-4e8c4dccc226"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("4ff2068f-6394-41b6-8228-915f0db26e24"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("62771190-e326-429f-b253-b7112db8e28d"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("66d54eb1-64bd-45f9-b2cc-db1d575fd570"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("72c79f91-ac64-4ff6-a14b-ad779fb8cdab"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("75e59689-9d18-414d-9037-f5177b0de36f"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("78e2f979-426e-404b-aaba-4d7d6e603132"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("794b185b-ce0c-4c93-a947-15091e9ed979"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("937ab0cd-20d9-4458-b648-49675d9deed7"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("995415ec-f9d9-4a2c-9283-8b0168db14fd"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9c30614a-4849-4463-81b0-284b90a84741"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9fff2ac6-e92b-4565-8149-8df5f1fe6bd2"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ab7f04c3-2f88-46c5-a218-055f7e9a9325"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("abc2c203-fcb7-497d-bc8c-54f83cdfb93f"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b377ed23-ed9d-4072-84e2-9f2e7dc06f8f"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("bd11ab09-6c84-4077-905a-6f2f53255e6c"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("c75f021e-f2a3-47b9-9956-590b686bb12a"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d6a53f44-56a6-4ec2-ba83-3995cc592b09"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ea1655d6-fc27-4dde-819b-f420d64285fe"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f40f6b52-2ff5-4a37-bd67-1ad00f2e29a5"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f43c48dc-ea73-450f-8255-92d20ff88576"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ffb35f56-8700-4750-bb1b-1647e1f3ad22"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("41c1d6bf-035b-490d-a5a5-80990a61ac32"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"));
        }
    }
}
