using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingLatestChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "4b6499b5-4efd-41e4-ab30-814702e7d63f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac73a6d-f7bb-4648-baaf-1add221ccccc",
                column: "ConcurrencyStamp",
                value: "7511bd46-bec3-4b53-84cd-8c58f1faee54");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b92cc6f-5864-499f-9c3e-213b32d18d32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b779a43b-8e88-4977-bc37-2b2b75e8572e", "AQAAAAEAACcQAAAAEEmzRFesfG1i6cpHi4XQQ8LJ2609msG7pPQee6tTWq87Q1Azw+QzoSGheRlVa+HNbA==", "d3de5017-35be-4242-b718-aad9105e3d6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b92dc6f-5864-499f-9c3e-213b32d18d62",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd7017c1-ebfe-4f9c-adb0-4536ea9dfed2", "AQAAAAEAACcQAAAAEC5Q72DwVpwGiT16t+vQtCBgb+NlheQP/zpPSHlJRVKLqaLl5x4oaqtPsTXlbedm5Q==", "ff839a98-acf2-4203-a1ca-e55e8d80243f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Period",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
