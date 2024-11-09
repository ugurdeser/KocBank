using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KocBank.Migrations
{
    /// <inheritdoc />
    public partial class q5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Balance",
                table: "CreditCard",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CardTypeID",
                table: "CreditCard",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CartTypeID",
                table: "CreditCard",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Limit",
                table: "CreditCard",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CardType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardType", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CreditCard_CardTypeID",
                table: "CreditCard",
                column: "CardTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_CreditCard_CardType_CardTypeID",
                table: "CreditCard",
                column: "CardTypeID",
                principalTable: "CardType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CreditCard_CardType_CardTypeID",
                table: "CreditCard");

            migrationBuilder.DropTable(
                name: "CardType");

            migrationBuilder.DropIndex(
                name: "IX_CreditCard_CardTypeID",
                table: "CreditCard");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "CreditCard");

            migrationBuilder.DropColumn(
                name: "CardTypeID",
                table: "CreditCard");

            migrationBuilder.DropColumn(
                name: "CartTypeID",
                table: "CreditCard");

            migrationBuilder.DropColumn(
                name: "Limit",
                table: "CreditCard");
        }
    }
}
