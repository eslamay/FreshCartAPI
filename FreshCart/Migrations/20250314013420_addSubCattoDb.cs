using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FreshCart.Migrations
{
    /// <inheritdoc />
    public partial class addSubCattoDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("046a4dd7-9529-4de1-bcd9-25e1f188577d"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3304), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("40d9125c-01b3-4084-b60f-2a4fee924765"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3301), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3301) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("41c1d6bf-035b-490d-a5a5-80990a61ac32"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3317), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3307), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("67f73162-8eff-43fe-b693-3951a800b20d"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3312), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("716b7818-280f-4c6d-b221-010b314d6929"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3319), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7bbb9a6e-27f2-49ca-a62a-59f04c940090"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3290), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3321), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b39860b5-91b7-41dd-b52b-22d2ee9c4ec4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3314), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3309), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3310) });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Name", "ProductId", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("05b68f1b-2f82-4a67-b7f9-dbd929715711"), new Guid("41c1d6bf-035b-490d-a5a5-80990a61ac32"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3599), "Makeup", null, "makeup", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3600) },
                    { new Guid("081af716-b1a1-40e0-aae3-3ef7133452e6"), new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3650), "Audio & Home Entertainment", null, "audio-and-home-entertainment", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3650) },
                    { new Guid("0883a5f0-5e11-407c-8d0a-6a4aed08f950"), new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3633), "Data Storage", null, "data-storage", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3633) },
                    { new Guid("1d9471ee-042a-4f5a-a88f-a1a999dc5e2d"), new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3624), "Bathing & Skin Care", null, "bathing-and-skin-care", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3624) },
                    { new Guid("1f066d73-4259-403d-97c7-4f8173f7c472"), new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3615), "Car Seats & Strollers", null, "car-seats-and-strollers", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3616) },
                    { new Guid("21ad8aaf-77fa-4659-bde9-49999dc883ca"), new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3653), "Laptops & Accessories", null, "laptops-and-accessories", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3653) },
                    { new Guid("35c94c09-9fab-4a70-90b5-36c81f832cf8"), new Guid("41c1d6bf-035b-490d-a5a5-80990a61ac32"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3593), "Skin Care", null, "skin-care", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3593) },
                    { new Guid("3f3e77e6-270b-464d-b4dd-8896ab15c09a"), new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3578), "Snack Food", null, "snack-food", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3578) },
                    { new Guid("44322ad4-8c7a-4d6f-9ea1-3bb52f56a966"), new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3656), "TVs, Satellites & Accessories", null, "tvs-satellites-and-accessories", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3656) },
                    { new Guid("46c2f155-b8ba-4785-9ca9-50065a86b2de"), new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3642), "Cameras & Accessories", null, "cameras-and-accessories", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3642) },
                    { new Guid("637315cb-516d-4dd8-9a8f-d7664de2e260"), new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3547), "Diapers & Diaper Bags", null, "diapers-and-diaper-bags", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3547) },
                    { new Guid("662b0a59-0c42-4dfa-89a3-039537a59f57"), new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3575), "Breakfast Food", null, "breakfast-food", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3575) },
                    { new Guid("679a4e5d-7964-4552-862c-584c24e57a5d"), new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3571), "Baby Food", null, "baby-food", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3572) },
                    { new Guid("8f2225a4-86e5-46e0-8711-d18a9414bf91"), new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3612), "Bouncers & Swings", null, "bouncers-and-swings", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3612) },
                    { new Guid("910240a7-ac53-480f-b80e-bd9343e8c6bf"), new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3621), "Nursing & Feeding", null, "nursing-and-feeding", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3621) },
                    { new Guid("916f85b4-7d93-4015-a65d-c0d4d29ea4f1"), new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3639), "Printers & Accessories", null, "printers-and-accessories", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3639) },
                    { new Guid("9698f6ab-e4e5-49bb-ab64-e7280276b9f0"), new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3581), "Home Care & Cleaning", null, "home-care-and-cleaning", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3581) },
                    { new Guid("a7702ae4-d228-46b3-97b6-a24cac9700e1"), new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3630), "Computer Components", null, "computer-components", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3630) },
                    { new Guid("b51ede19-8fb6-4605-92d5-fcbdeb71312e"), new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3565), "Pet Supplies", null, "pet-supplies", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3565) },
                    { new Guid("bd51ef41-bc6b-416c-a10c-f9f493e3e76f"), new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3606), "Toys", null, "toys", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3606) },
                    { new Guid("cc34e47d-a056-4a07-805e-10131e83ed82"), new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3647), "Video Games", null, "video-games", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3647) },
                    { new Guid("cd9bd982-a127-40ad-afd2-0379000ad06b"), new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3584), "Beverages", null, "beverages", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3584) },
                    { new Guid("d09ee4f2-be92-4704-98d4-16bf800909f9"), new Guid("41c1d6bf-035b-490d-a5a5-80990a61ac32"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3602), "Fragrance", null, "fragrance", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3603) },
                    { new Guid("d128b45b-75b1-45af-86d5-eec73e17a9cc"), new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3627), "Computer Accessories", null, "computer-accessories", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3627) },
                    { new Guid("d130d3ef-7988-4cd9-be5b-2746e9b2af93"), new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3551), "Baby Safety Products", null, "baby-safety-products", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3552) },
                    { new Guid("d2b1aa2f-6d3e-4c09-8ee2-efd0efc92f44"), new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3568), "Candy & Chocolate", null, "candy-and-chocolate", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3569) },
                    { new Guid("d4b855eb-234b-4f8f-a14c-9f516493df1d"), new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3609), "Potty Training", null, "potty-training", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3609) },
                    { new Guid("e7235a2d-9aef-4392-95a2-3255fd00c192"), new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3587), "Canned Dry and Packaged Foods", null, "canned-dry-and-packaged-foods", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3587) },
                    { new Guid("ea5f83d5-317a-4302-8141-753bafcb5de4"), new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3636), "Networking Products", null, "networking-products", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3636) },
                    { new Guid("edde2438-ec31-43de-b181-9f9e07ae8ab9"), new Guid("41c1d6bf-035b-490d-a5a5-80990a61ac32"), new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3596), "Hair Care", null, "hair-care", new DateTime(2025, 3, 14, 1, 34, 20, 260, DateTimeKind.Utc).AddTicks(3596) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("05b68f1b-2f82-4a67-b7f9-dbd929715711"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("081af716-b1a1-40e0-aae3-3ef7133452e6"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("0883a5f0-5e11-407c-8d0a-6a4aed08f950"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("1d9471ee-042a-4f5a-a88f-a1a999dc5e2d"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("1f066d73-4259-403d-97c7-4f8173f7c472"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("21ad8aaf-77fa-4659-bde9-49999dc883ca"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("35c94c09-9fab-4a70-90b5-36c81f832cf8"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3f3e77e6-270b-464d-b4dd-8896ab15c09a"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("44322ad4-8c7a-4d6f-9ea1-3bb52f56a966"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("46c2f155-b8ba-4785-9ca9-50065a86b2de"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("637315cb-516d-4dd8-9a8f-d7664de2e260"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("662b0a59-0c42-4dfa-89a3-039537a59f57"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("679a4e5d-7964-4552-862c-584c24e57a5d"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("8f2225a4-86e5-46e0-8711-d18a9414bf91"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("910240a7-ac53-480f-b80e-bd9343e8c6bf"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("916f85b4-7d93-4015-a65d-c0d4d29ea4f1"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9698f6ab-e4e5-49bb-ab64-e7280276b9f0"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("a7702ae4-d228-46b3-97b6-a24cac9700e1"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b51ede19-8fb6-4605-92d5-fcbdeb71312e"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("bd51ef41-bc6b-416c-a10c-f9f493e3e76f"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("cc34e47d-a056-4a07-805e-10131e83ed82"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("cd9bd982-a127-40ad-afd2-0379000ad06b"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d09ee4f2-be92-4704-98d4-16bf800909f9"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d128b45b-75b1-45af-86d5-eec73e17a9cc"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d130d3ef-7988-4cd9-be5b-2746e9b2af93"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d2b1aa2f-6d3e-4c09-8ee2-efd0efc92f44"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d4b855eb-234b-4f8f-a14c-9f516493df1d"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("e7235a2d-9aef-4392-95a2-3255fd00c192"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ea5f83d5-317a-4302-8141-753bafcb5de4"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("edde2438-ec31-43de-b181-9f9e07ae8ab9"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("046a4dd7-9529-4de1-bcd9-25e1f188577d"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8760), new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("40d9125c-01b3-4084-b60f-2a4fee924765"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8756), new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8757) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("41c1d6bf-035b-490d-a5a5-80990a61ac32"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8787), new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("451bbac9-4ae4-4c3d-a957-5c855af41d26"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8763), new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("67f73162-8eff-43fe-b693-3951a800b20d"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8781), new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("716b7818-280f-4c6d-b221-010b314d6929"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8791), new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7bbb9a6e-27f2-49ca-a62a-59f04c940090"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8750), new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8794), new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b39860b5-91b7-41dd-b52b-22d2ee9c4ec4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8784), new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8777), new DateTime(2025, 3, 13, 5, 57, 7, 576, DateTimeKind.Utc).AddTicks(8778) });
        }
    }
}
