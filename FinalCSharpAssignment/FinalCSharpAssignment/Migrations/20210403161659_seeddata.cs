using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalCSharpAssignment.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "EmailAddress", "FirstName", "LastName" },
                values: new object[] { 1, "hjhnsn82@hotmail.com", "Heather", "Hanson" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
