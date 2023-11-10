using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class ChangedDateTimeCols : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "LeaveRequests",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "LeaveRequests",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StartDate",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EndDate",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
        }
    }
}
