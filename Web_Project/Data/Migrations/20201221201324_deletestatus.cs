using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_Project.Data.Migrations
{
    public partial class deletestatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Category");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
