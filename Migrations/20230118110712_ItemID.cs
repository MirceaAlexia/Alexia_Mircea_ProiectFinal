using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alexia_Mircea_ProiectFinal.Migrations
{
    public partial class ItemID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemID",
                table: "Clothing",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemID",
                table: "Clothing");
        }
    }
}
