using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorInvoice.Migrations
{
    /// <inheritdoc />
    public partial class PaymentsPaid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Paid",
                table: "Payments",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Paid",
                table: "Payments");
        }
    }
}
