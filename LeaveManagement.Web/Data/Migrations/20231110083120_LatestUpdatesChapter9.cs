using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class LatestUpdatesChapter9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "507c1557-93b9-44fe-84d3-c5d10aa1a036");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac73a6d-f7bb-4648-baaf-1add221ccccc",
                column: "ConcurrencyStamp",
                value: "15b1962f-29a2-4c5b-8771-9586ea79a62b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b92cc6f-5864-499f-9c3e-213b32d18d32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbaa0dd0-7012-4427-a121-bae47fca7655", "AQAAAAEAACcQAAAAEHF9NLrnbJDzNum40cPyjnT2luk6KKJyaayLpeITcqOTjV6ui7aPd9DBri0RTKDUJg==", "bfe73e64-5fc6-4242-a391-81bc492e8fa7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b92dc6f-5864-499f-9c3e-213b32d18d62",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e367c65-f039-48c6-82fd-b97983183701", "AQAAAAEAACcQAAAAEBqjHtQaTSilxvlOzVMkDvMuWz9ghrHHJCaAZIaNfQvk7BXOxOvyDQBwWrB6hr4E5A==", "a180e958-1e69-4414-9ce6-5352cec67482" });
        }
    }
}
