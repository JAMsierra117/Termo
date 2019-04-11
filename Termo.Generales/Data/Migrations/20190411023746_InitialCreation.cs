using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Termo.Generales.Data.Migrations
{
    public partial class InitialCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Generales");

            migrationBuilder.CreateTable(
                name: "Clientes",
                schema: "Generales",
                columns: table => new
                {
                    ID_Cliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<string>(nullable: true),
                    ID_UsuarioAlta = table.Column<int>(nullable: true),
                    Alta = table.Column<DateTime>(nullable: true),
                    ID_UsuarioActualizacion = table.Column<int>(nullable: true),
                    Actualizacion = table.Column<DateTime>(nullable: true),
                    NombreCliente = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Ciudad = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ID_Cliente);
                });

            migrationBuilder.CreateTable(
                name: "FormasPagos",
                schema: "Generales",
                columns: table => new
                {
                    ID_FormaPago = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<string>(nullable: true),
                    ID_UsuarioAlta = table.Column<int>(nullable: true),
                    Alta = table.Column<DateTime>(nullable: true),
                    ID_UsuarioActualizacion = table.Column<int>(nullable: true),
                    Actualizacion = table.Column<DateTime>(nullable: true),
                    CodigoFormaPago = table.Column<int>(nullable: false),
                    NombreFormaPago = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormasPagos", x => x.ID_FormaPago);
                });

            migrationBuilder.CreateTable(
                name: "Lineas",
                schema: "Generales",
                columns: table => new
                {
                    ID_Linea = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<string>(nullable: true),
                    ID_UsuarioAlta = table.Column<int>(nullable: true),
                    Alta = table.Column<DateTime>(nullable: true),
                    ID_UsuarioActualizacion = table.Column<int>(nullable: true),
                    Actualizacion = table.Column<DateTime>(nullable: true),
                    CodigoLinea = table.Column<string>(nullable: true),
                    NombreLinea = table.Column<string>(nullable: true),
                    ID_Padre = table.Column<int>(nullable: false),
                    EsHijo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lineas", x => x.ID_Linea);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                schema: "Generales",
                columns: table => new
                {
                    ID_Producto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Activo = table.Column<string>(nullable: true),
                    ID_UsuarioAlta = table.Column<int>(nullable: true),
                    Alta = table.Column<DateTime>(nullable: true),
                    ID_UsuarioActualizacion = table.Column<int>(nullable: true),
                    Actualizacion = table.Column<DateTime>(nullable: true),
                    CodigoProducto = table.Column<string>(nullable: true),
                    NombreProducto = table.Column<string>(nullable: true),
                    ID_Linea = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ID_Producto);
                    table.ForeignKey(
                        name: "FK_Productos_Lineas_ID_Linea",
                        column: x => x.ID_Linea,
                        principalSchema: "Generales",
                        principalTable: "Lineas",
                        principalColumn: "ID_Linea",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_ID_Linea",
                schema: "Generales",
                table: "Productos",
                column: "ID_Linea");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes",
                schema: "Generales");

            migrationBuilder.DropTable(
                name: "FormasPagos",
                schema: "Generales");

            migrationBuilder.DropTable(
                name: "Productos",
                schema: "Generales");

            migrationBuilder.DropTable(
                name: "Lineas",
                schema: "Generales");
        }
    }
}
