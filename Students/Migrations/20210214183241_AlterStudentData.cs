using Microsoft.EntityFrameworkCore.Migrations;

namespace Students.Migrations
{
    public partial class AlterStudentData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "id", "Niveau", "code", "fullname" },
                values: new object[] { 2, "1", "A22", "Mohammed abboudi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
