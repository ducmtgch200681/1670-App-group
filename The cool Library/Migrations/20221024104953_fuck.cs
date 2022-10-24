using Microsoft.EntityFrameworkCore.Migrations;

namespace The_cool_Library.Migrations
{
    public partial class fuck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "d418c730-2ee9-4fcb-8cfa-0b887cfd4fd6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "b400b8eb-2bbb-46eb-8c4b-1762b3e0bb66");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C",
                column: "ConcurrencyStamp",
                value: "099a5199-6abb-4007-9001-8ebf13bab920");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d3a47c4-803c-4bcd-9eb6-7067324e8878", "AQAAAAEAACcQAAAAEIDRoZiAQw/4kpehk3hk6t/rDBw3F+2J5Hw90wHq+8dQ0AeiFAIGrp/gtY0dWlLB4A==", "d107cb65-f19e-409f-9509-a5e6589c0a2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec970d35-ecdb-4ea6-8433-bb215b03dd7c", "AQAAAAEAACcQAAAAEC3aLBSh3Lw3xgnbCgwaeRWPrElPjNvugWPrCw9GIj0C/STkKgckOjFPnjKW+zCBqA==", "41480aad-3f81-4166-ad09-1df9f802bbff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0d25447-23af-45f9-9216-49b6cecfa1a1", "AQAAAAEAACcQAAAAELWBiekJ8yhlWrAETQjVRK73OGZ5I88RohMUMbTW4kAR+12o23Z51AThx6Y3HLfXaw==", "7ebdccaa-f9d5-430c-bd6a-0b0f3b85e050" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "e1ba42e5-88de-4bc2-a4bc-0fa01b4b1634");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "c9d42215-44ac-4532-b809-fcd7ec9ffc49");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C",
                column: "ConcurrencyStamp",
                value: "79fa0c5c-2e4f-46fb-8321-8fa8cee9adc3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7ac5094-0729-4117-8d32-b6bb74980538", "AQAAAAEAACcQAAAAEFDWHGH0CzhVKDlhO2+5Mm9ywju2Vg9b4BzHhUptvh8bh14W3vhk7eXUNuCmi+e5uQ==", "74d40a53-aee7-4f64-b1a2-2b0e259daf69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "554b1f6c-825a-4e9b-b1f3-c902a30ee30f", "AQAAAAEAACcQAAAAEFRv/Xi330jd3jtCxKHDXkkTAj2NV8wLhmp10KmBNmAxlVnWr94fj62xmROek7o9oQ==", "108c4a6a-ff7a-458a-9d81-3b32e9a04600" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9ed27a6-9820-4efc-a09c-61c3e6e9f31e", "AQAAAAEAACcQAAAAEJUyChoMK1FECSm26o4XOQlkTHMF6K9lnEfQltjsHkr8KTddkNtU2jwXa0CAWQe9gg==", "929250ff-e0fc-4457-a08a-49a66a2d87ce" });
        }
    }
}
