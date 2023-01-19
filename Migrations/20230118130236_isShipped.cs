using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alexia_Mircea_ProiectFinal.Migrations
{
    public partial class isShipped : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsShipped",
                table: "Order",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsShipped",
                table: "Order");
        }
    }
}
