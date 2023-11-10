using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "a0f927f5-23e4-496e-b48e-6909d2f90588");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac73a6d-f7bb-4648-baaf-1add221ccccc",
                column: "ConcurrencyStamp",
                value: "34070875-f45e-41b3-8e30-885c83df31af");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b92cc6f-5864-499f-9c3e-213b32d18d32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b228fb71-f30f-4255-96a4-90d61196900d", "AQAAAAEAACcQAAAAECfkBTZTgJvBk2Dj7KU5Z4/5jsF+ISmVe/fZV5CCjkfSSmJ1li5v7QCm8A6Phcamdg==", "12edf0cf-c1da-4fb1-8cd7-6e0034e09fbc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b92dc6f-5864-499f-9c3e-213b32d18d62",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "305f4b23-5c13-436e-8798-2f278ead3078", "AQAAAAEAACcQAAAAEBTvHv1Zn3I7GeVVNOosEEzsjA4OmxlrrSBQRYsYeu0w5mh0RC3hUribAF4QsDyZaQ==", "b9fb5001-d354-415d-bf21-7cba1ea412c5" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
