using Microsoft.EntityFrameworkCore.Migrations;

namespace APIMinionsP2P.Migrations
{
    public partial class Addednameandsurnamecolumnsonuserstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
