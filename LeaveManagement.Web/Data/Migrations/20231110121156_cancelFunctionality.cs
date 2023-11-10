using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class cancelFunctionality : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "600fbde4-ba03-4937-9f0f-6c3a59985b85");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac73a6d-f7bb-4648-baaf-1add221ccccc",
                column: "ConcurrencyStamp",
                value: "d14af615-3e42-4f8e-ba54-81c39c68e886");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b92cc6f-5864-499f-9c3e-213b32d18d32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "552099e5-8e1f-4606-aad6-7f29e4377183", "AQAAAAEAACcQAAAAEMM7v+e2oIEdgCRMrfoh4gxIXzV4+RnzvTMVQxS9A77tUrwHlRbFY7p6f3q0VBxacQ==", "968e2827-a783-4e6e-ba7e-f36fadfcc0e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b92dc6f-5864-499f-9c3e-213b32d18d62",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4dba2020-cda3-424d-8fcd-d92d654b6eee", "AQAAAAEAACcQAAAAEHjB5k7VX4C9JdNU+CQAleo/kc/sJYynsDm+X3EeRCv2ZEYmC4KJS83Ku5IEGTq99Q==", "3bcb9b92-3b2e-4851-bb45-b5e5cf086180" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
