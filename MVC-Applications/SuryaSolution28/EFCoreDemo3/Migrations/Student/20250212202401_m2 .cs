using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreDemo3.Migrations.Student
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tblStudents",
                columns: new[] { "Id", "Course", "Fees", "SName" },
                values: new object[] { 5, "React", 25000, "Nithin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tblStudents",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
