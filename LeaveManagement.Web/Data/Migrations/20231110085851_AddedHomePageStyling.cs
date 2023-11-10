using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedHomePageStyling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "9f1fc0d3-70d0-40fa-a2ca-fb25e976716e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac73a6d-f7bb-4648-baaf-1add221ccccc",
                column: "ConcurrencyStamp",
                value: "95b9f6ff-512b-4a76-92b1-6a92e2440d6f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b92cc6f-5864-499f-9c3e-213b32d18d32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8339b38d-4447-46bc-b7bc-4cb5a634ae91", "AQAAAAEAACcQAAAAENZnEM1/wCioXLMugKps1tyvxFtuPpK+qBTnoP3RAZ1u8vQjSTjbKhsljyxo91JlfA==", "fcee7e38-ac3d-4ab5-b5cc-4012e7ab4ae3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b92dc6f-5864-499f-9c3e-213b32d18d62",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "713bf8e1-dd52-4338-8e2b-fe3434adabbb", "AQAAAAEAACcQAAAAEOXUhQGLO3MH1fllS5m4HJi7E6KnMhvVztNY4Ld6fzkSmOVa3TN/8iLw+NBfxtd4yA==", "7e6014bb-8e35-4dd3-88a6-c9af17b60958" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "0f44e1ff-19e4-43b1-b5ce-6e0da00c6b24");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac73a6d-f7bb-4648-baaf-1add221ccccc",
                column: "ConcurrencyStamp",
                value: "f1a3624f-a3d6-49d9-b3e5-f28b56f16272");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b92cc6f-5864-499f-9c3e-213b32d18d32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "679f9864-3e46-4444-aa92-fe9d0107e35f", "AQAAAAEAACcQAAAAEAzf6rynD7tanXVT6n9eO5tkPuphTKPNqidF9LKA4pwlMfGKgoWaOtiekDTLFvQzAA==", "523ec1e6-5b7a-47c6-9ca2-3d752b8e65c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b92dc6f-5864-499f-9c3e-213b32d18d62",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "097b1842-9ca6-4529-af78-e2c23806175e", "AQAAAAEAACcQAAAAEKlYCP9TGAwcs/NGuDe7sSSOY2SUeLS7q+9DBWu9fmfcrIivOszbqiaWidJXg2ACDA==", "2029f580-a6de-46f0-99ff-013a696f275b" });
        }
    }
}
