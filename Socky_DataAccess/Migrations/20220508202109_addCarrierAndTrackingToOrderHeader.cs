using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Socky_DataAccess.Migrations
{
    public partial class addCarrierAndTrackingToOrderHeader : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Carrier",
                table: "OrderHeader",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tracking",
                table: "OrderHeader",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Carrier",
                table: "OrderHeader");

            migrationBuilder.DropColumn(
                name: "Tracking",
                table: "OrderHeader");
        }
    }
}
