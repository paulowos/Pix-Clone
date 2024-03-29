using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedPixKeyIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Accounts_PixKey",
                table: "Accounts",
                column: "PixKey",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Accounts_PixKey",
                table: "Accounts");
        }
    }
}
