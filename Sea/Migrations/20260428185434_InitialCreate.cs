using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sea.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fish",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsEdible = table.Column<bool>(type: "bit", nullable: false),
                    IsDangerous = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Locations = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BreedingSeason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prevention = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxAge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fish", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fish_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FirstAid",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FishId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirstAid", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FirstAid_Fish_FishId",
                        column: x => x.FishId,
                        principalTable: "Fish",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FirstAid_FishId",
                table: "FirstAid",
                column: "FishId");

            migrationBuilder.CreateIndex(
                name: "IX_Fish_CategoryId",
                table: "Fish",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FirstAid");

            migrationBuilder.DropTable(
                name: "Fish");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
