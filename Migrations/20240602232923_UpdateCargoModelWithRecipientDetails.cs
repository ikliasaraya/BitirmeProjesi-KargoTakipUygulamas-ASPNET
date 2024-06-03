using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KargoTakipUygulaması.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCargoModelWithRecipientDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cargos_AspNetUsers_RecipientId",
                table: "Cargos");

            migrationBuilder.DropIndex(
                name: "IX_Cargos_RecipientId",
                table: "Cargos");

            migrationBuilder.DropColumn(
                name: "RecipientId",
                table: "Cargos");

            migrationBuilder.AddColumn<string>(
                name: "RecipientIdentityNumber",
                table: "Cargos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RecipientName",
                table: "Cargos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RecipientSurname",
                table: "Cargos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Cargos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cargos_UserId",
                table: "Cargos",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cargos_AspNetUsers_UserId",
                table: "Cargos",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cargos_AspNetUsers_UserId",
                table: "Cargos");

            migrationBuilder.DropIndex(
                name: "IX_Cargos_UserId",
                table: "Cargos");

            migrationBuilder.DropColumn(
                name: "RecipientIdentityNumber",
                table: "Cargos");

            migrationBuilder.DropColumn(
                name: "RecipientName",
                table: "Cargos");

            migrationBuilder.DropColumn(
                name: "RecipientSurname",
                table: "Cargos");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Cargos");

            migrationBuilder.AddColumn<string>(
                name: "RecipientId",
                table: "Cargos",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Cargos_RecipientId",
                table: "Cargos",
                column: "RecipientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cargos_AspNetUsers_RecipientId",
                table: "Cargos",
                column: "RecipientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
