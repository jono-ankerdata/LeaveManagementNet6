using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "0a4a9c62-a4e1-4d27-a817-6cfa71a6d230");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac73a6d-f7bb-4648-baaf-1add221ccccc",
                column: "ConcurrencyStamp",
                value: "9b97160e-0d96-4633-a7af-0d387fa5b753");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b92cc6f-5864-499f-9c3e-213b32d18d32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8d32318-ac23-429f-8489-ce6257cee9f2", "AQAAAAEAACcQAAAAEEH2ykvrs+47Es6+aQ65wiB6+jNmEuJjlDQgJ/BnezV91D6dWvJMAahaWaF4Hhnc6A==", "4ddb9d76-1839-4394-80f2-e5e8a95b640c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b92dc6f-5864-499f-9c3e-213b32d18d62",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f5f534e-c476-455b-8999-20aaf49f71ce", "AQAAAAEAACcQAAAAEIQi7GYiujAm1xqfeKhdhUO4G3TrP6V0WRjJsp7o0LgDSFrp6hQ9UeNXHYefuuR7aw==", "29a4a9e7-b704-4531-a126-d887056b6ff7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "1401224a-2555-459e-b946-22c7301bb2f7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac73a6d-f7bb-4648-baaf-1add221ccccc",
                column: "ConcurrencyStamp",
                value: "7dc2cde0-3ca0-484a-8702-ae28ee530119");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b92cc6f-5864-499f-9c3e-213b32d18d32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c27b7bc3-76b3-49ac-b904-454867f59c78", "AQAAAAEAACcQAAAAEKv62TGMJ8pp5g9myQJiSmPm472H+1YE6Y89MJ879a2TRVcruYTLim+RRZ/hTp2njA==", "ccc5c266-e7e8-443d-b19d-213bed118d9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b92dc6f-5864-499f-9c3e-213b32d18d62",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cb2c3db-3cdc-419b-a0ea-bd8c20daaad7", "AQAAAAEAACcQAAAAEBsZRVBs0ZN4+oIasRg9BXL1tLJcRpf8PRzZKyBDgxjyONISp2xAoVk+ztS0e1CyCw==", "11ea1195-768d-48d1-8446-a1b3853ebf27" });
        }
    }
}
