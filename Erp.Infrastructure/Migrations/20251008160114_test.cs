using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Erp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BrandTestId",
                schema: "Inventory",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BrandTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandTests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    BrandTestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryTests_BrandTests_BrandTestId",
                        column: x => x.BrandTestId,
                        principalTable: "BrandTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_BrandTestId",
                schema: "Inventory",
                table: "Categories",
                column: "BrandTestId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTests_BrandTestId",
                table: "CategoryTests",
                column: "BrandTestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_BrandTests_BrandTestId",
                schema: "Inventory",
                table: "Categories",
                column: "BrandTestId",
                principalTable: "BrandTests",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_BrandTests_BrandTestId",
                schema: "Inventory",
                table: "Categories");

            migrationBuilder.DropTable(
                name: "CategoryTests");

            migrationBuilder.DropTable(
                name: "BrandTests");

            migrationBuilder.DropIndex(
                name: "IX_Categories_BrandTestId",
                schema: "Inventory",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "BrandTestId",
                schema: "Inventory",
                table: "Categories");
        }
    }
}
