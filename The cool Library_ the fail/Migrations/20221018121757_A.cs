using Microsoft.EntityFrameworkCore.Migrations;

namespace The_cool_Library.Migrations
{
    public partial class A : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "70b3dfd5-638d-4130-80ee-3cefc3fc46a2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "3849b852-9883-4964-a54c-a3d4a5070ada");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C",
                column: "ConcurrencyStamp",
                value: "af9ef822-d978-4324-9f7d-46b4e76629c1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "220ae0de-d786-4a11-a111-a210a4c1d430", "AQAAAAEAACcQAAAAEGlXXvyrVi6uOXQoWQPIEYh24h1/Y5AeNT1g1awbyeo5DJ7ZQmVW5HLAYXBJsJRymg==", "c826df3e-2333-4834-8649-3cf629b45619" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bade4fff-648a-4547-a7b1-4b69a6fd533b", "AQAAAAEAACcQAAAAEK+BO1CVkgPbbRGN65aLyHFwI0q1A3mVQkZjfstevkWJIWXw2VMOL7bk4PlzqZhryQ==", "d64150dc-e6f3-419d-a6fb-7b022632ddd4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d37583a8-0ddd-4392-9cb9-1c7656f73a3f", "AQAAAAEAACcQAAAAEEYOBoLrwETgUppk4u5hoQmhuMqN0jm9PYCx3FCFUPU8HanoQqVYgJtnarqS0ByGAg==", "66b48c66-854e-42de-b1f4-d9815960c605" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "c0c515cc-3fd9-43e4-b86a-094ce5628219");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "d0ef6013-3895-47dc-b311-1eb38be5039f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C",
                column: "ConcurrencyStamp",
                value: "7f7b54f2-df37-4273-ba2c-c28eeb0f2459");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71ecb188-862e-409c-94de-4e574cee0f44", "AQAAAAEAACcQAAAAECmDAr2LUgNjJD30kXY25xG7ABcx27WdD0JQ89zUnEA+ZSXP09epnA5tuh6EBVkPnQ==", "9f7f4bca-4a80-4e11-baf3-8d1953edd772" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d0cdb53-f9d0-49dc-b268-8a84fa040635", "AQAAAAEAACcQAAAAECHnTYf+xIlaLDJT+hR1RvFz2E3V4iYDrdw4QrgL0wGaD6I/QQ91iZr6JgWfjQq8wQ==", "d8d23e98-56be-4fc9-8c2c-5ed35f0f081a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ba686cf-0303-4e78-9a91-29bcde840ed1", "AQAAAAEAACcQAAAAENV192qHdmby+hoQ7YOKEfuDSi49K4vkO/FQylvI0pLg3gqow9hPKe6r1nEOEEPHXQ==", "a9dffb0a-b987-4c33-9815-d2b0b928a5f0" });
        }
    }
}
