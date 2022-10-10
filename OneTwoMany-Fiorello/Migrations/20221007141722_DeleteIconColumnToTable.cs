using Microsoft.EntityFrameworkCore.Migrations;

namespace OneTwoMany_Fiorello.Migrations
{
    public partial class DeleteIconColumnToTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Abouts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
