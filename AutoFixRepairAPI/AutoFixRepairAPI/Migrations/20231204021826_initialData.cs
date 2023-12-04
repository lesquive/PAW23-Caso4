using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutoFixRepairAPI.Migrations
{
    /// <inheritdoc />
    public partial class initialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "InformacionServicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformacionServicios", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TiposReparacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposReparacion", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SolicitudesReparacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    TipoReparacionId = table.Column<int>(type: "int", nullable: false),
                    IdMecanicoAsignado = table.Column<int>(type: "int", nullable: true),
                    Completada = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ModeloAutomovil = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MarcaAutomovil = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AnioAutomovil = table.Column<int>(type: "int", nullable: false),
                    PlacaAutomovil = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudesReparacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitudesReparacion_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolicitudesReparacion_TiposReparacion_TipoReparacionId",
                        column: x => x.TipoReparacionId,
                        principalTable: "TiposReparacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "Apellido", "Direccion", "Email", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "García", "Calle Principal", "juan@example.com", "Juan", "123456789" },
                    { 2, "López", "Avenida Central", "maria@example.com", "María", "987654321" },
                    { 3, "Martínez", "Calle Secundaria", "pedro@example.com", "Pedro", "456789123" },
                    { 4, "Rodríguez", "Plaza Principal", "ana@example.com", "Ana", "741852963" },
                    { 5, "Gómez", "Avenida Norte", "carlos@example.com", "Carlos", "159263487" },
                    { 6, "Díaz", "Calle Sur", "laura@example.com", "Laura", "369852147" },
                    { 7, "Hernández", "Avenida Oeste", "javier@example.com", "Javier", "258147369" },
                    { 8, "Pérez", "Calle Este", "sofia@example.com", "Sofía", "147852369" }
                });

            migrationBuilder.InsertData(
                table: "InformacionServicios",
                columns: new[] { "Id", "Descripcion", "Titulo" },
                values: new object[,]
                {
                    { 1, "Especialistas en reparación de motores para automóviles de todas las marcas.", "Reparación de Motor" },
                    { 2, "Servicio rápido y eficiente de cambio de neumáticos con las mejores marcas del mercado.", "Cambio de Neumáticos" },
                    { 3, "Mantenimiento completo de automóviles para garantizar su rendimiento y durabilidad.", "Revisión y Mantenimiento" },
                    { 4, "Especialistas en reparación y mantenimiento de sistemas de frenos y suspensión.", "Frenos y Suspensión" },
                    { 5, "Servicio de diagnóstico, reparación y mantenimiento de sistemas de aire acondicionado.", "Aire Acondicionado" },
                    { 6, "Reparación y diagnóstico de problemas en el sistema eléctrico del automóvil.", "Sistema Eléctrico" },
                    { 7, "Cambio de aceite y filtro con productos de calidad para el mejor rendimiento del motor.", "Cambio de Aceite" },
                    { 8, "Servicio de inspección y corrección para cumplir con los estándares de emisiones.", "Inspección de Emisiones" },
                    { 9, "Reparación de daños en la carrocería con acabados de alta calidad.", "Reparación de Carrocería" },
                    { 10, "Diagnóstico avanzado mediante sistemas computarizados para problemas técnicos.", "Diagnóstico Computarizado" },
                    { 11, "Asistencia y reparación de emergencia las 24 horas del día, los 7 días de la semana.", "Servicio de Emergencia" },
                    { 12, "Servicio de remolque para vehículos averiados hasta nuestro taller.", "Servicio de Remolque" },
                    { 13, "Programas de mantenimiento preventivo para evitar problemas futuros.", "Servicio de Mantenimiento Preventivo" }
                });

            migrationBuilder.InsertData(
                table: "TiposReparacion",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Reparación de Motor" },
                    { 2, "Cambio de Neumáticos" },
                    { 3, "Revisión y Mantenimiento" },
                    { 4, "Frenos y Suspensión" },
                    { 5, "Aire Acondicionado" },
                    { 6, "Sistema Eléctrico" },
                    { 7, "Cambio de Aceite" },
                    { 8, "Inspección de Emisiones" },
                    { 9, "Reparación de Carrocería" },
                    { 10, "Diagnóstico Computarizado" },
                    { 11, "Servicio de Emergencia" },
                    { 12, "Servicio de Remolque" },
                    { 13, "Servicio de Mantenimiento Preventivo" }
                });

            migrationBuilder.InsertData(
                table: "SolicitudesReparacion",
                columns: new[] { "Id", "AnioAutomovil", "ClienteId", "Completada", "IdMecanicoAsignado", "MarcaAutomovil", "ModeloAutomovil", "PlacaAutomovil", "TipoReparacionId" },
                values: new object[,]
                {
                    { 1, 2022, 1, false, null, "Marca X", "Modelo A", "XYZ456", 1 },
                    { 2, 2022, 2, false, null, "Marca X", "Modelo A", "XYZ456", 2 },
                    { 3, 2022, 3, false, null, "Marca X", "Modelo A", "XYZ456", 3 },
                    { 4, 2022, 4, false, null, "Marca X", "Modelo A", "XYZ456", 4 },
                    { 5, 2022, 5, false, null, "Marca X", "Modelo A", "XYZ456", 5 },
                    { 6, 2022, 6, false, null, "Marca X", "Modelo A", "XYZ456", 6 },
                    { 7, 2022, 7, false, null, "Marca X", "Modelo A", "XYZ456", 7 },
                    { 8, 2022, 3, false, null, "Marca X", "Modelo A", "XYZ456", 8 },
                    { 9, 2022, 5, false, null, "Marca X", "Modelo A", "XYZ456", 9 },
                    { 10, 2022, 1, false, null, "Marca X", "Modelo A", "XYZ456", 10 },
                    { 11, 2022, 3, false, null, "Marca X", "Modelo A", "XYZ456", 11 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudesReparacion_ClienteId",
                table: "SolicitudesReparacion",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudesReparacion_TipoReparacionId",
                table: "SolicitudesReparacion",
                column: "TipoReparacionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InformacionServicios");

            migrationBuilder.DropTable(
                name: "SolicitudesReparacion");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "TiposReparacion");
        }
    }
}
