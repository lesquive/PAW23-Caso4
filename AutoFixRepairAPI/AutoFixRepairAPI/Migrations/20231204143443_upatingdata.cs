using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoFixRepairAPI.Migrations
{
    /// <inheritdoc />
    public partial class upatingdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SolicitudesReparacion_Clientes_ClienteId",
                table: "SolicitudesReparacion");

            migrationBuilder.DropForeignKey(
                name: "FK_SolicitudesReparacion_TiposReparacion_TipoReparacionId",
                table: "SolicitudesReparacion");

            migrationBuilder.DropIndex(
                name: "IX_SolicitudesReparacion_ClienteId",
                table: "SolicitudesReparacion");

            migrationBuilder.DropIndex(
                name: "IX_SolicitudesReparacion_TipoReparacionId",
                table: "SolicitudesReparacion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SolicitudesReparacion_ClienteId",
                table: "SolicitudesReparacion",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudesReparacion_TipoReparacionId",
                table: "SolicitudesReparacion",
                column: "TipoReparacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitudesReparacion_Clientes_ClienteId",
                table: "SolicitudesReparacion",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SolicitudesReparacion_TiposReparacion_TipoReparacionId",
                table: "SolicitudesReparacion",
                column: "TipoReparacionId",
                principalTable: "TiposReparacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
