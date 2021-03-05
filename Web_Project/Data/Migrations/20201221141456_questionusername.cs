using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_Project.Data.Migrations
{
    public partial class questionusername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Question",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Question");
        }
    }
}
