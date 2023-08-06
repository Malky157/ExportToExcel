using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeveloperProject.Migrations
{
    public partial class another : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Active",
                table: "Facilities",
                newName: "Live");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Live",
                table: "Facilities",
                newName: "Active");
        }
    }
}
