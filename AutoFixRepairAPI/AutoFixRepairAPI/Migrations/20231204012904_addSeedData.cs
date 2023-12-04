using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutoFixRepairAPI.Migrations
{
    /// <inheritdoc />
    public partial class addSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Id", "ClienteId", "Completada", "IdMecanicoAsignado", "TipoReparacionId" },
                values: new object[,]
                {
                    { 1, 1, false, null, 1 },
                    { 2, 2, false, null, 2 },
                    { 3, 3, false, null, 3 },
                    { 4, 4, false, null, 4 },
                    { 5, 5, false, null, 5 },
                    { 6, 6, false, null, 6 },
                    { 7, 7, false, null, 7 },
                    { 8, 3, false, null, 8 },
                    { 9, 5, false, null, 9 },
                    { 10, 1, false, null, 10 },
                    { 11, 3, false, null, 11 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "InformacionServicios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InformacionServicios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InformacionServicios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InformacionServicios",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "InformacionServicios",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "InformacionServicios",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "InformacionServicios",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "InformacionServicios",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "InformacionServicios",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "InformacionServicios",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "InformacionServicios",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "InformacionServicios",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "InformacionServicios",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SolicitudesReparacion",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SolicitudesReparacion",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SolicitudesReparacion",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SolicitudesReparacion",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SolicitudesReparacion",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SolicitudesReparacion",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SolicitudesReparacion",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SolicitudesReparacion",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SolicitudesReparacion",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SolicitudesReparacion",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SolicitudesReparacion",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TiposReparacion",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TiposReparacion",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TiposReparacion",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TiposReparacion",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TiposReparacion",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TiposReparacion",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TiposReparacion",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TiposReparacion",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TiposReparacion",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TiposReparacion",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TiposReparacion",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TiposReparacion",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TiposReparacion",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
