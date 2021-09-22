using Microsoft.EntityFrameworkCore.Migrations;

namespace Ensek.Persistence.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "ensek",
                table: "Accounts",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 2344, "Tommy", "Test" },
                    { 1246, "Jo", "Test" },
                    { 1245, "Neville", "Test" },
                    { 1244, "Tony", "Test" },
                    { 1243, "Graham", "Test" },
                    { 1242, "Tim", "Test" },
                    { 1241, "Lara", "Test" },
                    { 1240, "Archie", "Test" },
                    { 1239, "Noddy", "Test" },
                    { 1234, "Freya", "Test" },
                    { 4534, "JOSH", "TEST" },
                    { 6776, "Laura", "Test" },
                    { 1247, "Jim", "Test" },
                    { 2356, "Craig", "Test" },
                    { 2353, "Tony", "Test" },
                    { 2352, "Greg", "Test" },
                    { 2351, "Gladys", "Test" },
                    { 2350, "Colin", "Test" },
                    { 2349, "Simon", "Test" },
                    { 2348, "Tammy", "Test" },
                    { 2347, "Tara", "Test" },
                    { 2346, "Ollie", "Test" },
                    { 2345, "Jerry", "Test" },
                    { 8766, "Sally", "Test" },
                    { 2233, "Barry", "Test" },
                    { 2355, "Arthur", "Test" },
                    { 1248, "Pam", "Test" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "ensek",
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1234);

            migrationBuilder.DeleteData(
                schema: "ensek",
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1239);

            migrationBuilder.DeleteData(
                schema: "ensek",
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1240);

            migrationBuilder.DeleteData(
                schema: "ensek",
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1241);

            migrationBuilder.DeleteData(
                schema: "ensek",
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1242);

            migrationBuilder.DeleteData(
                schema: "ensek",
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1243);

            migrationBuilder.DeleteData(
                schema: "ensek",
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1244);

            migrationBuilder.DeleteData(
                schema: "ensek",
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1245);

            migrationBuilder.DeleteData(
                schema: "ensek",
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1246);

            migrationBuilder.DeleteData(
                schema: "ensek",
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1247);

            migrationBuilder.DeleteData(
                schema: "ensek",
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1248);

            migrationBuilder.DeleteData(
                schema: "ensek",
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2233);

            migrationBuilder.DeleteData(
                schema: "ensek",
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2344);

            migrationBuilder.DeleteData(
                schema: "ensek",
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2345);

            migrationBuilder.DeleteData(
                schema: "ensek",
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2346);

            migrationBuilder.DeleteData(
                schema: "ensek",
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2347);

            migrationBuilder.DeleteData(
                schema: "ensek",
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2348);

            migrationBuilder.DeleteData(
                schema: "ensek",
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2349);

            migrationBuilder.DeleteData(
                schema: "ensek",
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2350);

            migrationBuilder.DeleteData(
                schema: "ensek",
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2351);

            migrationBuilder.DeleteData(
                schema: "ensek",
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2352);

            migrationBuilder.DeleteData(
                schema: "ensek",
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2353);

            migrationBuilder.DeleteData(
                schema: "ensek",
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2355);

            migrationBuilder.DeleteData(
                schema: "ensek",
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2356);

            migrationBuilder.DeleteData(
                schema: "ensek",
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4534);

            migrationBuilder.DeleteData(
                schema: "ensek",
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6776);

            migrationBuilder.DeleteData(
                schema: "ensek",
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 8766);
        }
    }
}
