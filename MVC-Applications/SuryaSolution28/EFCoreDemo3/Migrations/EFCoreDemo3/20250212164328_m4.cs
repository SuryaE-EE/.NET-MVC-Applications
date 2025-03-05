using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreDemo3.Migrations.EFCoreDemo3
{
    /// <inheritdoc />
    public partial class m4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 10);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tblEmployees",
                columns: new[] { "Id", "EName", "Job", "Salary" },
                values: new object[,]
                {
                    { 9, "Dumminy", "Developer", 18000 },
                    { 10, "Dale", "Trainer", 25000 }
                });
        }
    }
}
