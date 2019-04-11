using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Termo.Generales.Data.Migrations
{
    public partial class AddZonasImpuestos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ZonasImpuestos",
                schema: "Generales",
                columns: table => new
                {
                    ID_ZonaImpuesto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<string>(nullable: true),
                    ID_UsuarioAlta = table.Column<int>(nullable: true),
                    Alta = table.Column<DateTime>(nullable: true),
                    ID_UsuarioActualizacion = table.Column<int>(nullable: true),
                    Actualizacion = table.Column<DateTime>(nullable: true),
                    NombreZonaImpuesto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZonasImpuestos", x => x.ID_ZonaImpuesto);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ZonasImpuestos",
                schema: "Generales");
        }
    }
}
