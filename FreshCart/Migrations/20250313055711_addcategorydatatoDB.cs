using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FreshCart.Migrations
{
    /// <inheritdoc />
    public partial class addcategorydatatoDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "ImageUrl", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("046a4dd7-9529-4de1-bcd9-25e1f188577d"), new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8760), "https://ecommerce.routemisr.com/Route-Academy-categories/1681511818071.jpeg", "Women's Fashion", "women's-fashion", new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8760) },
                    { new Guid("40d9125c-01b3-4084-b60f-2a4fee924765"), new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8756), "https://ecommerce.routemisr.com/Route-Academy-categories/1681511865180.jpeg", "Men's Fashion", "men's-fashion", new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8757) },
                    { new Guid("41c1d6bf-035b-490d-a5a5-80990a61ac32"), new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8787), "https://ecommerce.routemisr.com/Route-Academy-categories/1681511179514.png", "Beauty & Health", "beauty-and-health", new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8788) },
                    { new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"), new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8763), "https://ecommerce.routemisr.com/Route-Academy-categories/1681511452254.png", "SuperMarket", "supermarket", new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8763) },
                    { new Guid("67f73162-8eff-43fe-b693-3951a800b20d"), new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8781), "https://ecommerce.routemisr.com/Route-Academy-categories/1681511392672.png", "Home", "home", new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8782) },
                    { new Guid("716b7818-280f-4c6d-b221-010b314d6929"), new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8791), "https://ecommerce.routemisr.com/Route-Academy-categories/1681511156008.png", "Mobiles", "mobiles", new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8791) },
                    { new Guid("7bbb9a6e-27f2-49ca-a62a-59f04c940090"), new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8750), "https://ecommerce.routemisr.com/Route-Academy-categories/1681511964020.jpeg", "Music", "music", new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8753) },
                    { new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8794), "https://ecommerce.routemisr.com/Route-Academy-categories/1681511121316.png", "Electronics", "electronics", new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8794) },
                    { new Guid("b39860b5-91b7-41dd-b52b-22d2ee9c4ec4"), new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8784), "https://ecommerce.routemisr.com/Route-Academy-categories/1681511368164.png", "Books", "books", new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8785) },
                    { new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"), new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8777), "https://ecommerce.routemisr.com/Route-Academy-categories/1681511427130.png", "Baby & Toys", "baby-and-toys", new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8778) }
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
                keyValue: new Guid("41c1d6bf-035b-490d-a5a5-80990a61ac32"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"));

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
                keyValue: new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b39860b5-91b7-41dd-b52b-22d2ee9c4ec4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"));
        }
    }
}
