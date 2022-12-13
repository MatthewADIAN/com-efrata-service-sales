using Microsoft.EntityFrameworkCore.Migrations;

namespace Com.Efrata.Service.Sales.Lib.Migrations
{
    public partial class addUseVat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "UseVat",
                table: "GarmentSalesContracts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "VatValue",
                table: "GarmentSalesContracts",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UseVat",
                table: "GarmentSalesContracts");

            migrationBuilder.DropColumn(
                name: "VatValue",
                table: "GarmentSalesContracts");
        }
    }
}
