using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreDemo3.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tblEmployees",
                columns: new[] { "Id", "EName", "Job", "Salary" },
                values: new object[,]
                {
                    { 3, "Ryan Tendoscarte", "Analyst", 35000 },
                    { 4, "Ryan McLaren", "Analyst", 35000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
