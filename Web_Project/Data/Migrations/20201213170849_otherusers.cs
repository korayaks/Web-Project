using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_Project.Data.Migrations
{
    public partial class otherusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OtherUsers",
                table: "Project",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OtherUsers",
                table: "Project");
        }
    }
}
