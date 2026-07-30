using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sea.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreMarineAnimals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 4,
                column: "FishId",
                value: 7);

            migrationBuilder.InsertData(
                table: "Fish",
                columns: new[] { "Id", "BreedingSeason", "CategoryId", "Description", "ImageUrl", "IsDangerous", "IsEdible", "Locations", "MaxAge", "MaxSize", "Name", "Prevention" },
                values: new object[,]
                {
                    { 17, "Spring", 1, "Popular food fish in Saudi Arabia.", "/images/emperor.jpg", false, true, "Red Sea & Arabian Gulf", "15 years", "80 cm", "Emperor Fish (الشعري)", "No risk" },
                    { 18, "Summer", 1, "Common reef fish.", "/images/Rabbitfish.jpg", false, true, "Red Sea", "8 years", "40 cm", "Rabbitfish (الصافي)", "No risk" },
                    { 19, "Summer", 1, "Widely consumed fish.", "/images/Tilapia.jpg", false, true, "Saudi coastal waters", "10 years", "60 cm", "Tilapia (البلطي)", "No risk" },
                    { 20, "All year", 2, "Can bite when threatened.", "/images/MorayEel.jpg", true, false, "Red Sea", "30 years", "2 meters", "Moray Eel (ثعبان البحر)", "Keep your distance" },
                    { 21, "Summer", 2, "Highly venomous marine snake.", "/images/SeaSnake.jpg", true, false, "Red Sea", "10 years", "1.5 meters", "Sea Snake (ثعبان البحر السام)", "Never touch it" },
                    { 22, "Spring", 2, "A marine ray with a venomous tail spine that can cause serious injuries.", "/images/Stingray.jpg", true, false, "Red Sea & Arabian Gulf", "20 years", "2 meters", "Stingray (اللخمة)", "Shuffle your feet while walking in shallow water and avoid touching it." }
                });

            migrationBuilder.InsertData(
                table: "FirstAids",
                columns: new[] { "Id", "Description", "FishId", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 9, "Wash the wound with clean water, control bleeding, cover it with a sterile dressing, and seek medical attention to prevent infection.", 20, "/images/MorayEel.jpg", "Moray Eel Bite" },
                    { 10, "Keep the victim calm and still, immobilize the affected limb, and seek emergency medical care immediately. Do not cut the wound or try to suck out the venom.", 21, "/images/SeaSnake.jpg", "Sea Snake Bite" },
                    { 11, "Control bleeding, soak the injured area in hot (not boiling) water for 30–90 minutes, clean the wound, and seek medical attention immediately.", 22, "/images/Stingray.jpg", "Stingray Injury" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.UpdateData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 4,
                column: "FishId",
                value: 8);
        }
    }
}
