using Microsoft.EntityFrameworkCore.Migrations;

namespace Citizens.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "CitizenPersonalDetail",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "CitizenPersonalDetail",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "CitizenPersonalDetail");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "CitizenPersonalDetail");
        }
    }
}
