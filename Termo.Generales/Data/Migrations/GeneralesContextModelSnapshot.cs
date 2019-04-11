﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Termo.Generales.Data;

namespace Termo.Generales.Data.Migrations
{
    [DbContext(typeof(GeneralesContext))]
    partial class GeneralesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Generales")
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Termo.Generales.Core.Cliente", b =>
                {
                    b.Property<int>("ID_Cliente")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Activo");

                    b.Property<DateTime?>("Actualizacion");

                    b.Property<DateTime?>("Alta");

                    b.Property<string>("Ciudad");

                    b.Property<string>("Direccion");

                    b.Property<string>("Email");

                    b.Property<string>("Estado");

                    b.Property<int?>("ID_UsuarioActualizacion");

                    b.Property<int?>("ID_UsuarioAlta");

                    b.Property<string>("NombreCliente");

                    b.Property<string>("Telefono");

                    b.HasKey("ID_Cliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Termo.Generales.Core.FormaPago", b =>
                {
                    b.Property<int>("ID_FormaPago")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Activo");

                    b.Property<DateTime?>("Actualizacion");

                    b.Property<DateTime?>("Alta");

                    b.Property<int>("CodigoFormaPago");

                    b.Property<int?>("ID_UsuarioActualizacion");

                    b.Property<int?>("ID_UsuarioAlta");

                    b.Property<string>("NombreFormaPago")
                        .HasMaxLength(200);

                    b.HasKey("ID_FormaPago");

                    b.ToTable("FormasPagos");
                });

            modelBuilder.Entity("Termo.Generales.Core.Impuesto", b =>
                {
                    b.Property<int>("ID_Impuesto")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Activo");

                    b.Property<DateTime?>("Actualizacion");

                    b.Property<DateTime?>("Alta");

                    b.Property<int?>("ID_UsuarioActualizacion");

                    b.Property<int?>("ID_UsuarioAlta");

                    b.Property<string>("NombreImpuesto");

                    b.Property<decimal>("Porcentaje")
                        .HasColumnType("decimal(16, 2)");

                    b.HasKey("ID_Impuesto");

                    b.ToTable("Impuestos");
                });

            modelBuilder.Entity("Termo.Generales.Core.Linea", b =>
                {
                    b.Property<int>("ID_Linea")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Activo");

                    b.Property<DateTime?>("Actualizacion");

                    b.Property<DateTime?>("Alta");

                    b.Property<string>("CodigoLinea");

                    b.Property<bool>("EsHijo");

                    b.Property<int>("ID_Padre");

                    b.Property<int?>("ID_UsuarioActualizacion");

                    b.Property<int?>("ID_UsuarioAlta");

                    b.Property<string>("NombreLinea");

                    b.HasKey("ID_Linea");

                    b.ToTable("Lineas");
                });

            modelBuilder.Entity("Termo.Generales.Core.Producto", b =>
                {
                    b.Property<int>("ID_Producto")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Activo");

                    b.Property<DateTime?>("Actualizacion");

                    b.Property<DateTime?>("Alta");

                    b.Property<string>("CodigoProducto");

                    b.Property<int>("ID_Linea");

                    b.Property<int?>("ID_UsuarioActualizacion");

                    b.Property<int?>("ID_UsuarioAlta");

                    b.Property<string>("NombreProducto");

                    b.HasKey("ID_Producto");

                    b.HasIndex("ID_Linea");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Termo.Generales.Core.ZonaImpuesto", b =>
                {
                    b.Property<int>("ID_ZonaImpuesto")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Activo");

                    b.Property<DateTime?>("Actualizacion");

                    b.Property<DateTime?>("Alta");

                    b.Property<int?>("ID_UsuarioActualizacion");

                    b.Property<int?>("ID_UsuarioAlta");

                    b.Property<string>("NombreZonaImpuesto");

                    b.HasKey("ID_ZonaImpuesto");

                    b.ToTable("ZonasImpuestos");
                });

            modelBuilder.Entity("Termo.Generales.Core.Producto", b =>
                {
                    b.HasOne("Termo.Generales.Core.Linea", "Linea")
                        .WithMany()
                        .HasForeignKey("ID_Linea")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
