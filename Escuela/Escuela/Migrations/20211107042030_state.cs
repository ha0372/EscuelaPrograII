using Microsoft.EntityFrameworkCore.Migrations;

namespace Escuela.Migrations
{
    public partial class state : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "stateStudent",
                table: "Students",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "stateStudent",
                table: "Students");
        }
    }
}
