using Microsoft.EntityFrameworkCore.Migrations;

namespace Com.Efrata.Service.Sales.Lib.Migrations
{
    public partial class changeTypeDataBOQUantity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "BOQuantity",
                table: "CostCalculationGarments",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BOQuantity",
                table: "CostCalculationGarments",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
