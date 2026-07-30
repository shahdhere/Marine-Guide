using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sea.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFishSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "/images/Cuttlefish.jpg");

            migrationBuilder.InsertData(
                table: "Fish",
                columns: new[] { "Id", "BreedingSeason", "CategoryId", "Description", "ImageUrl", "IsDangerous", "IsEdible", "Locations", "MaxAge", "MaxSize", "Name", "Prevention" },
                values: new object[,]
                {
                    { 23, "Spring", 1, "A smart marine creature with eight arms. It can change color and shape for protection.", "/images/Octopus.jpg", false, true, "Red Sea & Arabian Gulf", "5 years", "1.5 meters", "Octopus (الأخطبوط)", "Avoid touching wild octopus as some species can be venomous." },
                    { 24, "Spring", 1, "A fast-moving marine animal that uses ink as a defense mechanism.", "/images/Squid.jpg", false, true, "Red Sea & Arabian Gulf", "2 years", "1 meter", "Squid (الحبار)", "No major risk" },
                    { 25, "Summer", 1, "A marine crustacean with a hard shell and strong claws.", "/images/Lobster.jpg", false, true, "Red Sea", "50 years", "60 cm", "Lobster (جراد البحر)", "Be careful of claws when handling." },
                    { 26, "All year", 1, "A common seafood crustacean found in coastal waters.", "/images/Shrimp.jpg", false, true, "Red Sea & Arabian Gulf", "6 years", "25 cm", "Shrimp (الروبيان)", "No risk" },
                    { 27, "Summer", 2, "A marine animal covered with sharp spines that can cause injuries.", "/images/SeaUrchin.jpg", true, false, "Red Sea", "20 years", "15 cm", "Sea Urchin (قنفذ البحر)", "Avoid stepping on it and do not touch with bare hands." },
                    { 28, "Spring", 1, "A marine animal with a star-shaped body that lives on the seabed.", "/images/Starfish.jpg", false, false, "Red Sea", "35 years", "30 cm", "Starfish (نجم البحر)", "Do not remove from water." },
                    { 29, "All year", 1, "An intelligent marine mammal known for its social behavior.", "/images/Dolphin.jpg", false, false, "Red Sea", "60 years", "4 meters", "Dolphin (الدلفين)", "Do not disturb or approach wild dolphins." },
                    { 30, "Winter", 1, "A large marine mammal found in deep ocean waters.", "/images/Whale.jpg", false, false, "Red Sea", "70 years", "15 meters", "Whale (الحوت)", "Keep distance from wild whales." },
                    { 31, "Summer", 1, "A marine animal that helps clean the ocean floor.", "/images/SeaCucumber.jpg", false, false, "Red Sea", "10 years", "40 cm", "Sea Cucumber (خيار البحر)", "Avoid collecting protected species." },
                    { 32, "All year", 1, "Marine ecosystem that provides shelter for many sea creatures.", "/images/Coral.jpg", false, false, "Red Sea", "Hundreds of years", "Several meters", "Coral (الشعاب المرجانية)", "Do not touch or damage coral reefs." },
                    { 33, "All year", 2, "A marine animal with stinging tentacles that may irritate skin.", "/images/SeaAnemon.jpg", true, false, "Red Sea", "50 years", "50 cm", "Sea Anemone (شقائق النعمان البحرية)", "Avoid touching tentacles." },
                    { 34, "Summer", 2, "A marine organism that can cause painful skin irritation.", "/images/FireCoral.jpg", true, false, "Red Sea", "Many years", "1 meter", "Fire Coral (المرجان الناري)", "Do not touch underwater." },
                    { 35, "Summer", 2, "A venomous marine snail that can inject dangerous toxins.", "/images/ConeSnail.jpg", true, false, "Red Sea", "10 years", "20 cm", "Cone Snail (حلزون البحر المخروطي)", "Never pick up shells with living creatures inside." },
                    { 36, "Spring", 2, "A highly venomous octopus with a dangerous bite.", "/images/Blue-RingedOctopus.jpg", true, false, "Warm coastal waters", "2 years", "20 cm", "Blue-Ringed Octopus (الأخطبوط ذو الحلقات الزرقاء)", "Never touch it." },
                    { 37, "Summer", 2, "A large predatory shark species known for powerful hunting ability.", "/images/GreatWhiteShark.jpg", true, false, "Red Sea & Open Oceans", "70 years", "6 meters", "Great White Shark (القرش الأبيض الكبير)", "Avoid approaching large sharks." }
                });

            migrationBuilder.InsertData(
                table: "FirstAids",
                columns: new[] { "Id", "Description", "FishId", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 12, "Remove visible spines carefully, wash the area, soak in warm water to reduce pain, and seek medical help if spines remain.", 27, "/images/SeaUrchin.jpg", "Sea Urchin Injury" },
                    { 13, "Rinse the affected area with seawater, remove tentacles carefully, and seek medical advice if irritation continues.", 33, "/images/SeaAnemon.jpg", "Sea Anemone Sting" },
                    { 14, "Rinse with seawater, avoid rubbing the skin, and treat irritation with appropriate first aid.", 34, "/images/FireCoral.jpg", "Fire Coral Contact" },
                    { 15, "Do not touch the animal. Immobilize the affected area and seek emergency medical care immediately.", 35, "/images/ConeSnail.jpg", "Cone Snail Sting" },
                    { 16, "Seek emergency medical help immediately. Keep the victim still and monitor breathing.", 36, "/images/Blue-RingedOctopus.jpg", "Blue-Ringed Octopus Bite" },
                    { 17, "Stop bleeding, clean and cover the wound, and seek emergency medical assistance immediately.", 37, "/images/GreatWhiteShark.jpg", "Shark Bite" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "/images/Cuttlefish.jpeg");
        }
    }
}
