using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Abp.FamilyTree.Migrations
{
    public partial class AddedNameToHumans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "HumanHumanity",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "HumanHumanity");
        }
    }
}
