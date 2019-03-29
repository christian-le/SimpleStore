using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleStore.Infrastructure.Data.Migrations
{
    public partial class UpdateOrderDetailId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "OrderDetail",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "OrderDetail",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
