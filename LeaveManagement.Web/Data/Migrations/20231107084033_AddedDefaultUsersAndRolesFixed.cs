using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRolesFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e6ec3d11-4d01-4f24-88e2-396967ca454c", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEN6tIFN0L7A8lUkHmdDHxGpugWgJGPre2BUryuS720sJhBZxgCgjVXah3CIjZHFb5Q==", "57ca0f8b-9fc3-4e85-9b1f-5ab723344974", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b92dc6f-5864-499f-9c3e-213b32d18d62",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "04f13658-0039-40f4-aaad-ee8836542a82", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEEKlnEZMTfZ1iAizaewClCj0kNiZlddzne8RCpYvWZEINInWZsINa4JRlfmEvkiIIQ==", "3de5f8a8-4589-4570-99a0-9e4fa1f989ea", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "142e53bc-80aa-4682-813e-df08d610c277");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac73a6d-f7bb-4648-baaf-1add221ccccc",
                column: "ConcurrencyStamp",
                value: "4366e0f6-f8cb-4476-9652-00d71045251e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b92cc6f-5864-499f-9c3e-213b32d18d32",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ad133dd3-463d-42a1-8e2b-bcbdc59066f6", false, null, "AQAAAAEAACcQAAAAEO4LO47R/MVnmx0Hh2R4PoRn/DV6N3zu2xwLjuTycJhQax/DxtJnsS1MjoplH/56Ug==", "ead72db4-115a-433f-95c7-a959fce5837d", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b92dc6f-5864-499f-9c3e-213b32d18d62",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "225b8385-9eae-4d2b-a103-82dd1fea7ef5", false, null, "AQAAAAEAACcQAAAAEDkz4SmULTmzeZjx15z++4aNENUhTapFEEFP97KO3TIcwSszjgnK7lDLBELnVTVJdA==", "8bff9216-43c3-4257-8178-8ef876d71c2d", null });
        }
    }
}
