using Microsoft.EntityFrameworkCore.Migrations;

namespace Com.Efrata.Service.Sales.Lib.Migrations
{
    public partial class addVatId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VatId",
                table: "GarmentSalesContracts",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VatId",
                table: "GarmentSalesContracts");
        }
    }
}
