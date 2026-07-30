using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sea.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 37);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Fish",
                columns: new[] { "Id", "BreedingSeason", "CategoryId", "Description", "ImageUrl", "IsDangerous", "IsEdible", "Locations", "MaxAge", "MaxSize", "Name", "Prevention" },
                values: new object[] { 37, "Summer", 2, "A large predatory shark species known for powerful hunting ability.", "/images/GreatWhiteShark.jpg", true, false, "Red Sea & Open Oceans", "70 years", "6 meters", "Great White Shark (القرش الأبيض الكبير)", "Avoid approaching large sharks." });

            migrationBuilder.InsertData(
                table: "FirstAids",
                columns: new[] { "Id", "Description", "FishId", "ImageUrl", "Title" },
                values: new object[] { 17, "Stop bleeding, clean and cover the wound, and seek emergency medical assistance immediately.", 37, "/images/GreatWhiteShark.jpg", "Shark Bite" });
        }
    }
}
