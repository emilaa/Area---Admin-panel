using Microsoft.EntityFrameworkCore.Migrations;

namespace OneTwoMany_Fiorello.Migrations
{
    public partial class AddIconColumnToTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Abouts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Abouts");
        }
    }
}
