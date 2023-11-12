using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarritoDeCompra_1_Clientes_ClienteId",
                table: "CarritoDeCompra_1");

            migrationBuilder.DropForeignKey(
                name: "FK_CarritoDeCompra_1_Productos_ProductoId",
                table: "CarritoDeCompra_1");

            migrationBuilder.DropIndex(
                name: "IX_CarritoDeCompra_1_ClienteId",
                table: "CarritoDeCompra_1");

            migrationBuilder.DropIndex(
                name: "IX_CarritoDeCompra_1_ProductoId",
                table: "CarritoDeCompra_1");

            migrationBuilder.RenameColumn(
                name: "ProductoId",
                table: "CarritoDeCompra_1",
                newName: "ProductosIds");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductosIds",
                table: "CarritoDeCompra_1",
                newName: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_CarritoDeCompra_1_ClienteId",
                table: "CarritoDeCompra_1",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_CarritoDeCompra_1_ProductoId",
                table: "CarritoDeCompra_1",
                column: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarritoDeCompra_1_Clientes_ClienteId",
                table: "CarritoDeCompra_1",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarritoDeCompra_1_Productos_ProductoId",
                table: "CarritoDeCompra_1",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
