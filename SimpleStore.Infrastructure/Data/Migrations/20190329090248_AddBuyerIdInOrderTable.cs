using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleStore.Infrastructure.Data.Migrations
{
    public partial class AddBuyerIdInOrderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BuyerId",
                table: "Orders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BuyerId",
                table: "Orders");
        }
    }
}
