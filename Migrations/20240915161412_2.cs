using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KocBank.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "BankBranch");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "BankBranch",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
