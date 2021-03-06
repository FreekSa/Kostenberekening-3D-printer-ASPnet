﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Kostenberekening_3D_printer_ASPnet.Migrations
{
    public partial class intnaarvarchar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: false),
                    Kleur = table.Column<string>(nullable: false),
                    KostPerRol = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    AantalKg = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    AantalMeter = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stock");
        }
    }
}
