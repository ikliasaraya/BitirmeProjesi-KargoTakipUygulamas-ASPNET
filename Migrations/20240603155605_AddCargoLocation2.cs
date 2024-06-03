using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KargoTakipUygulaması.Migrations
{
    /// <inheritdoc />
    public partial class AddCargoLocation2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Cargos",
                type: "float",
                nullable: false,
                defaultValue: 37.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Cargos",
                type: "float",
                nullable: false,
                defaultValue: 35.321300000000001);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Cargos");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Cargos");
        }
    }
}
