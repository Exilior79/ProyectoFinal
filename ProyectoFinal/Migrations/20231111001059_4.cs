using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal.Migrations
{
    /// <inheritdoc />
    public partial class _4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductosIds",
                table: "CarritoDeCompra_1");

            migrationBuilder.AddColumn<int>(
                name: "ProductosIdsId",
                table: "CarritoDeCompra_1",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarritoDeCompra_1_ProductosIdsId",
                table: "CarritoDeCompra_1",
                column: "ProductosIdsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarritoDeCompra_1_Productos_ProductosIdsId",
                table: "CarritoDeCompra_1",
                column: "ProductosIdsId",
                principalTable: "Productos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarritoDeCompra_1_Productos_ProductosIdsId",
                table: "CarritoDeCompra_1");

            migrationBuilder.DropIndex(
                name: "IX_CarritoDeCompra_1_ProductosIdsId",
                table: "CarritoDeCompra_1");

            migrationBuilder.DropColumn(
                name: "ProductosIdsId",
                table: "CarritoDeCompra_1");

            migrationBuilder.AddColumn<int>(
                name: "ProductosIds",
                table: "CarritoDeCompra_1",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
