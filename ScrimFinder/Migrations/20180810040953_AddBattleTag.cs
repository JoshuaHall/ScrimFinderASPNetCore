using Microsoft.EntityFrameworkCore.Migrations;

namespace ScrimFinder.Migrations
{
    public partial class AddBattleTag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BattleTag",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BattleTag",
                table: "AspNetUsers");
        }
    }
}
