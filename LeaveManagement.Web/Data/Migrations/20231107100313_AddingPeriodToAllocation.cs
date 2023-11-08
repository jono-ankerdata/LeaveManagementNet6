using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Period",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "936efbc6-dc4d-4340-9332-927c1d91ce2c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac73a6d-f7bb-4648-baaf-1add221ccccc",
                column: "ConcurrencyStamp",
                value: "7d13075b-210f-481d-9e6a-db90c7420cfa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b92cc6f-5864-499f-9c3e-213b32d18d32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afc70e17-59fe-4f00-908f-c024941fd81c", "AQAAAAEAACcQAAAAEF50mfW7tCi8aOtLeNZUlX7IdScLENxfnNWlt4qSdQmqui3eA7UVOIvA98M2wlAHYA==", "63729c84-f040-42aa-a2a0-d62363e6b4f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b92dc6f-5864-499f-9c3e-213b32d18d62",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bb9c796-d5ae-4595-8611-fef8bb3440ba", "AQAAAAEAACcQAAAAEGPTskI6y1WhKQJKdo0AeNuLvqaEKQwmhS5NX6vlUSUHVkCbX9Dot/2C/2gMebukmQ==", "d8133677-14a6-4d4a-af1d-a476fe2c2bb4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "88c8113a-0972-4a89-a2f7-63911469f8de");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac73a6d-f7bb-4648-baaf-1add221ccccc",
                column: "ConcurrencyStamp",
                value: "5ead485b-a318-46ea-8b3e-bb3b839eae67");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b92cc6f-5864-499f-9c3e-213b32d18d32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6ec3d11-4d01-4f24-88e2-396967ca454c", "AQAAAAEAACcQAAAAEN6tIFN0L7A8lUkHmdDHxGpugWgJGPre2BUryuS720sJhBZxgCgjVXah3CIjZHFb5Q==", "57ca0f8b-9fc3-4e85-9b1f-5ab723344974" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b92dc6f-5864-499f-9c3e-213b32d18d62",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04f13658-0039-40f4-aaad-ee8836542a82", "AQAAAAEAACcQAAAAEEKlnEZMTfZ1iAizaewClCj0kNiZlddzne8RCpYvWZEINInWZsINa4JRlfmEvkiIIQ==", "3de5f8a8-4589-4570-99a0-9e4fa1f989ea" });
        }
    }
}
