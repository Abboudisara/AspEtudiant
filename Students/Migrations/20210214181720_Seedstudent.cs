using Microsoft.EntityFrameworkCore.Migrations;

namespace Students.Migrations
{
    public partial class Seedstudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "id", "Niveau", "code", "fullname" },
                values: new object[] { 1, "4", "A11", "sara abboudi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "id",
                keyValue: 1);
        }
    }
}
