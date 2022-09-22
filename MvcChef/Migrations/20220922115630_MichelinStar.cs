using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcChef.Migrations
{
    public partial class MichelinStar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MichelinStars",
                table: "Chef",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MichelinStars",
                table: "Chef");
        }
    }
}
