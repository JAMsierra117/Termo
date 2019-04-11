using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Termo.Generales.Data.Migrations
{
    public partial class AddImpuesto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Impuestos",
                schema: "Generales",
                columns: table => new
                {
                    ID_Impuesto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<string>(nullable: true),
                    ID_UsuarioAlta = table.Column<int>(nullable: true),
                    Alta = table.Column<DateTime>(nullable: true),
                    ID_UsuarioActualizacion = table.Column<int>(nullable: true),
                    Actualizacion = table.Column<DateTime>(nullable: true),
                    NombreImpuesto = table.Column<string>(nullable: true),
                    Porcentaje = table.Column<decimal>(type: "decimal(16, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Impuestos", x => x.ID_Impuesto);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Impuestos",
                schema: "Generales");
        }
    }
}
