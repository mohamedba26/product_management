using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace chaabene.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    subtype = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OfferDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    price = table.Column<float>(type: "real", nullable: false),
                    quantity = table.Column<float>(type: "real", nullable: false),
                    prooductId = table.Column<int>(type: "int", nullable: false),
                    productId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OfferDetails_Products_productId",
                        column: x => x.productId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OfferDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.id);
                    table.ForeignKey(
                        name: "FK_Offers_OfferDetails_OfferDetailId",
                        column: x => x.OfferDetailId,
                        principalTable: "OfferDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Archieves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Archive = table.Column<DateTime>(type: "datetime2", nullable: false),
                    offerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Archieves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Archieves_Offers_offerId",
                        column: x => x.offerId,
                        principalTable: "Offers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Archieves_offerId",
                table: "Archieves",
                column: "offerId");

            migrationBuilder.CreateIndex(
                name: "IX_OfferDetails_productId",
                table: "OfferDetails",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_OfferDetailId",
                table: "Offers",
                column: "OfferDetailId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Archieves");

            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "OfferDetails");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
