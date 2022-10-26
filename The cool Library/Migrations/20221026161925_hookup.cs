using Microsoft.EntityFrameworkCore.Migrations;

namespace The_cool_Library.Migrations
{
    public partial class hookup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_IUsId1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_IUsId1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "IUsId1",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "IUsId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdentityUserId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "221709ac-efff-48ef-8573-012b09a759e8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "ab42edd2-1c39-4e42-8ac0-1eb839efa7bc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C",
                column: "ConcurrencyStamp",
                value: "7fbce428-9baf-4db9-ba62-bd6db5127714");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47cc66cd-4cfb-4e28-8d04-2b1354164baf", "AQAAAAEAACcQAAAAEFJf3nBBq5ahcoeCg5RkGSfpeO9zsVxDj9643PPeMLLdok1SUd1UhRu/MpAYp2fk5Q==", "58fb05e5-969c-4b1d-a15d-428a15968d5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c51e63a9-6209-42dc-9e4b-dc9745096234", "AQAAAAEAACcQAAAAEF9Hjzv/RbBEAWHSYOqbSuwCLHhKpUDEhoAkJ7Uc/R1quXlYytOiyNLfPq1pk0QSzQ==", "95a41bba-57eb-43b5-a860-d68cf32917f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d7cce99-7737-40df-bd89-c8727ffc09a9", "AQAAAAEAACcQAAAAEPWVn6jLETpQdG3ZT8rY+3o1jvvwChMi8M2SKWV6dNJpqaJjI3PF4+L7aPaYAFMSHg==", "71822a3d-06d0-4bac-acf4-52e8fd46ae99" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_IUsId",
                table: "Orders",
                column: "IUsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_IUsId",
                table: "Orders",
                column: "IUsId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_IUsId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_IUsId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "IUsId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IUsId1",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "bb84040d-f5c0-4ac9-a4b4-9c065376b74f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "1104d86e-e092-493a-8ec1-52a05b8fdac1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C",
                column: "ConcurrencyStamp",
                value: "2715ef09-b5ef-4e19-819c-00ae7afe2aef");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "293525ee-ef55-4aa4-9c96-dfa91cce8037", "AQAAAAEAACcQAAAAENud8aKFixJ3N8SOqNGYyIFk2RYKX+EHhhU06moK33WXg/WsiVJ+T2QxIy61tz3PcQ==", "6ee95b9a-b1c3-4e2e-a131-2a4b8ceaf1d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77a8d3d8-1486-4ee4-ae63-d396b1a26851", "AQAAAAEAACcQAAAAEH8NBigH0mHNRQEt6fWL0uMRqqApsUBZcJy/sLeAyrp94ip+ZfDTZvaY7a6Jz3c5PQ==", "0675e143-7b9a-464f-b12e-2b052688db5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a835492c-f26d-4990-a52c-ca4b35fb0dde", "AQAAAAEAACcQAAAAEJ9th+0LOVRzoRduultabYDGdIBOQ6SonEBR3v1IRy6Ksl+o3yXqWfvx/6JkHtqRrw==", "e4c693c5-7915-444d-840b-caf8a560c433" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_IUsId1",
                table: "Orders",
                column: "IUsId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_IUsId1",
                table: "Orders",
                column: "IUsId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
