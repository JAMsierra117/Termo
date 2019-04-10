using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Termo.Generales.Data.Migrations
{
    public partial class FormaPago : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormasPagos",
                schema: "Generales",
                columns: table => new
                {
                    ID_FormaPago = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodigoFormaPago = table.Column<int>(nullable: false),
                    NombreFormaPago = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormasPagos", x => x.ID_FormaPago);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormasPagos",
                schema: "Generales");
        }
    }
}
