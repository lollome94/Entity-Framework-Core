using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class v19 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NominalPowerDue",
                table: "Plant");

            migrationBuilder.RenameColumn(
                name: "NominalPowerTre",
                table: "Plant",
                newName: "NominalPower");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NominalPower",
                table: "Plant",
                newName: "NominalPowerTre");

            migrationBuilder.AddColumn<double>(
                name: "NominalPowerDue",
                table: "Plant",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
