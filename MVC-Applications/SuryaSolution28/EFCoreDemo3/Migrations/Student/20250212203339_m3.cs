using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreDemo3.Migrations.Student
{
    /// <inheritdoc />
    public partial class m3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tblStudents",
                columns: new[] { "Id", "Course", "Fees", "SName" },
                values: new object[] { 6, "Angular", 25000, "Rohit" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tblStudents",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
