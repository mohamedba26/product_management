using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace chaabene.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "prooductId",
                table: "OfferDetails");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "prooductId",
                table: "OfferDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
