using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorInvoice.Migrations
{
    /// <inheritdoc />
    public partial class InvoiceItemsCostPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CostPrice",
                table: "InvoiceItems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CostPrice",
                table: "InvoiceItems");
        }
    }
}
