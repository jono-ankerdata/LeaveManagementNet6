using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class LatestUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
