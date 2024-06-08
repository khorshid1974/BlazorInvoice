using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorInvoice.Migrations
{
    /// <inheritdoc />
    public partial class Balancd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Balance",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Items");
        }
    }
}
