using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alexia_Mircea_ProiectFinal.Migrations
{
    public partial class Clothing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClothingID",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_ClothingID",
                table: "Order",
                column: "ClothingID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Clothing_ClothingID",
                table: "Order",
                column: "ClothingID",
                principalTable: "Clothing",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Clothing_ClothingID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_ClothingID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ClothingID",
                table: "Order");
        }
    }
}
