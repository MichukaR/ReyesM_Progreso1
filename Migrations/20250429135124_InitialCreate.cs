using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MichelleReyesP1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Nombre = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    edad = table.Column<int>(type: "integer", maxLength: 3, nullable: false),
                    Telefono = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    pregunta = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlanDeRecompensas",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fecha_de_inicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    nombre = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    puntosAcumulados = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanDeRecompensas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", maxLength: 10, nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fecha_entrada = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_salida = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ValorAPagar = table.Column<double>(type: "double precision", nullable: false),
                    infromacionCliente = table.Column<string>(type: "text", nullable: false),
                    informacionCliente = table.Column<string>(type: "character varying(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Reservas_Clientes_informacionCliente",
                        column: x => x.informacionCliente,
                        principalTable: "Clientes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_informacionCliente",
                table: "Reservas",
                column: "informacionCliente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlanDeRecompensas");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
