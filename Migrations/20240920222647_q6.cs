using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KocBank.Migrations
{
    /// <inheritdoc />
    public partial class q6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CartTypeID",
                table: "CreditCard");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "CreditCard",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "CreditCard");

            migrationBuilder.AddColumn<int>(
                name: "CartTypeID",
                table: "CreditCard",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
