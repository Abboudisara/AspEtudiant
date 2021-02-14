using Microsoft.EntityFrameworkCore.Migrations;

namespace Students.Migrations
{
    public partial class seedStudent3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "id", "Niveau", "code", "fullname" },
                values: new object[] { 3, "3", "A33", "Brahim abboudi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
