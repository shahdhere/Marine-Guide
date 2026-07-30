using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sea.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreFish : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Fish",
                columns: new[] { "Id", "BreedingSeason", "CategoryId", "Description", "ImageUrl", "IsDangerous", "IsEdible", "Locations", "MaxAge", "MaxSize", "Name", "Prevention" },
                values: new object[,]
                {
                    { 11, "Summer", 2, "من أشهر المفترسات البحرية في العالم.", "/images/shark.jpg", true, false, "Red Sea", "30 years", "6 meters", "Shark (القرش)", "Avoid deep water swimming" },
                    { 12, "Spring", 1, "سمكة صغيرة تعيش في مجموعات كبيرة.", "/images/sardine.jpg", false, true, "Arabian Gulf", "5 years", "30 cm", "Sardine (السردين)", "No risk" },
                    { 13, "Summer", 1, "سمكة ملونة تعيش قرب الشعاب المرجانية.", "/images/parrotfish.jpg", false, true, "Red Sea", "7 years", "1 meter", "Parrotfish (سمكة الببغاء)", "No risk" },
                    { 14, "All year", 1, "سمكة صغيرة تعيش بين شقائق النعمان البحرية.", "/images/clownfish.jpg", false, false, "Red Sea", "6 years", "15 cm", "Clownfish (سمكة المهرج)", "No risk" },
                    { 15, "Spring", 2, "كائن بحري قد يهاجم عند الاقتراب منه.", "/images/eel.jpg", true, false, "Red Sea", "20 years", "4 meters", "Moray Eel (ثعبان البحر)", "Do not approach reefs" },
                    { 16, "Summer", 1, "كائن بحري يعيش لفترات طويلة.", "/images/turtle.jpg", false, false, "Red Sea & Arabian Gulf", "80 years", "1.5 meters", "Sea Turtle (السلحفاة البحرية)", "Protected species" },
                    { 17, "Summer", 2, "كائن بحري لاسع قد يسبب ألم شديد.", "/images/jellyfish.jpg", true, false, "Red Sea", "1 year", "40 cm", "Jellyfish (قنديل البحر)", "Avoid touching" },
                    { 18, "Spring", 1, "رخوي بحري سريع الحركة ويستخدم الحبر للدفاع.", "/images/cuttlefish.jpg", false, true, "Arabian Gulf", "2 years", "50 cm", "Cuttlefish (الحبار)", "No risk" },
                    { 19, "Summer", 1, "من القشريات البحرية المنتشرة بالخليج.", "/images/crab.jpg", false, true, "Arabian Gulf", "4 years", "25 cm", "Blue Crab (السلطعون الأزرق)", "Watch for claws" },
                    { 20, "Summer", 2, "ثعبان بحري سام يعيش في المياه الدافئة.", "/images/seasnake.jpg", true, false, "Red Sea", "10 years", "2 meters", "Sea Snake (ثعبان البحر السام)", "Do not approach" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 16);

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
        }
    }
}
