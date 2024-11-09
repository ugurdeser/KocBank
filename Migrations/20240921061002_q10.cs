using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KocBank.Migrations
{
    /// <inheritdoc />
    public partial class q10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutoPayment_Account_AccountID",
                table: "AutoPayment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AutoPayment",
                table: "AutoPayment");

            migrationBuilder.RenameTable(
                name: "AutoPayment",
                newName: "AutoPaymentList");

            migrationBuilder.RenameIndex(
                name: "IX_AutoPayment_AccountID",
                table: "AutoPaymentList",
                newName: "IX_AutoPaymentList_AccountID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AutoPaymentList",
                table: "AutoPaymentList",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AutoPaymentList_Account_AccountID",
                table: "AutoPaymentList",
                column: "AccountID",
                principalTable: "Account",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutoPaymentList_Account_AccountID",
                table: "AutoPaymentList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AutoPaymentList",
                table: "AutoPaymentList");

            migrationBuilder.RenameTable(
                name: "AutoPaymentList",
                newName: "AutoPayment");

            migrationBuilder.RenameIndex(
                name: "IX_AutoPaymentList_AccountID",
                table: "AutoPayment",
                newName: "IX_AutoPayment_AccountID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AutoPayment",
                table: "AutoPayment",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AutoPayment_Account_AccountID",
                table: "AutoPayment",
                column: "AccountID",
                principalTable: "Account",
                principalColumn: "ID");
        }
    }
}
