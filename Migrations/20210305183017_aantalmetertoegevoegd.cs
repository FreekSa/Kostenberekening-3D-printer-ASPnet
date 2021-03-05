using Microsoft.EntityFrameworkCore.Migrations;

namespace Kostenberekening_3D_printer_ASPnet.Migrations
{
    public partial class aantalmetertoegevoegd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AantalMeter",
                table: "Filamenten",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AantalMeter",
                table: "Filamenten");
        }
    }
}
