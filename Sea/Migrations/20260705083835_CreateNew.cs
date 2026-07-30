using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sea.Migrations
{
    /// <inheritdoc />
    public partial class CreateNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FirstAids_Fish_FishId",
                table: "FirstAids");

            migrationBuilder.DeleteData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 9);

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

            migrationBuilder.UpdateData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/Barracuda.jpg");

            migrationBuilder.UpdateData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/Lionfish.jpg");

            migrationBuilder.UpdateData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/Stonefish.jpg");

            migrationBuilder.UpdateData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "/images/Pufferfish.jpg");

            migrationBuilder.UpdateData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FishId", "ImageUrl" },
                values: new object[] { 14, "/images/Jellyfish.jpg" });

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/Grouper.jpg");

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/Kingfish.jpg");

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/Barracuda.jpg");

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "/images/Lionfish.jpg");

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "/images/Stonefish.jpg");

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BreedingSeason", "Description", "ImageUrl", "Locations", "MaxAge", "MaxSize", "Name" },
                values: new object[] { "Winter", "من أشهر أسماك الخليج العربي.", "/images/Hamour.jpg", "Arabian Gulf", "15 years", "1.2 meters", "Hamour (هامور الخليج)" });

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BreedingSeason", "CategoryId", "Description", "ImageUrl", "IsDangerous", "IsEdible", "Locations", "MaxAge", "MaxSize", "Name", "Prevention" },
                values: new object[] { "Summer", 2, "سمكة سامة جدًا تحتوي على سم قاتل.", "/images/Pufferfish.jpg", true, false, "Red Sea & Arabian Gulf", "10 years", "60 cm", "Pufferfish (سمكة النفاخ)", "Do not eat or touch" });

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BreedingSeason", "CategoryId", "Description", "ImageUrl", "IsDangerous", "IsEdible", "Locations", "MaxSize", "Name", "Prevention" },
                values: new object[] { "Spring", 1, "سمكة سريعة تعيش في أسراب.", "/images/mackerel.jpg", false, true, "Arabian Gulf", "50 cm", "Mackerel (الماكريل)", "No risk" });

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BreedingSeason", "Description", "ImageUrl", "MaxAge", "MaxSize", "Name", "Prevention" },
                values: new object[] { "Summer", "من أشهر المفترسات البحرية في العالم.", "/images/Shark.jpg", "30 years", "6 meters", "Shark (القرش)", "Avoid deep water swimming" });

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "MaxAge", "MaxSize", "Name" },
                values: new object[] { "سمكة صغيرة تعيش في مجموعات كبيرة.", "/images/Sardine.jpg", "5 years", "30 cm", "Sardine (السردين)" });

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "IsDangerous", "IsEdible", "MaxAge", "MaxSize", "Name", "Prevention" },
                values: new object[] { 1, "سمكة ملونة تعيش قرب الشعاب المرجانية.", "/images/Parrotfish.jpg", false, true, "7 years", "1 meter", "Parrotfish (سمكة الببغاء)", "No risk" });

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BreedingSeason", "Description", "ImageUrl", "IsEdible", "Locations", "MaxAge", "MaxSize", "Name" },
                values: new object[] { "All year", "سمكة صغيرة تعيش بين شقائق النعمان البحرية.", "/images/Clownfish.jpg", false, "Red Sea", "6 years", "15 cm", "Clownfish (سمكة المهرج)" });

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageUrl", "IsEdible", "Locations", "MaxAge", "MaxSize", "Name", "Prevention" },
                values: new object[] { "كائن بحري يعيش لفترات طويلة.", "/images/Turtle.jpg", false, "Red Sea & Arabian Gulf", "80 years", "1.5 meters", "Sea Turtle (السلحفاة البحرية)", "Protected species" });

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BreedingSeason", "CategoryId", "Description", "ImageUrl", "IsDangerous", "MaxAge", "MaxSize", "Name", "Prevention" },
                values: new object[] { "Summer", 2, "كائن بحري لاسع قد يسبب ألم شديد.", "/images/Jellyfish.jpg", true, "1 year", "40 cm", "Jellyfish (قنديل البحر)", "Avoid touching" });

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "IsDangerous", "IsEdible", "Locations", "MaxAge", "MaxSize", "Name", "Prevention" },
                values: new object[] { 1, "رخوي بحري سريع الحركة ويستخدم الحبر للدفاع.", "/images/Cuttlefish.jpeg", false, true, "Arabian Gulf", "2 years", "50 cm", "Cuttlefish (الحبار)", "No risk" });

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ImageUrl", "IsEdible", "Locations", "MaxAge", "MaxSize", "Name", "Prevention" },
                values: new object[] { "من القشريات البحرية المنتشرة بالخليج.", "/images/Crab.jpg", true, "Arabian Gulf", "4 years", "25 cm", "Blue Crab (السلطعون الأزرق)", "Watch for claws" });

            migrationBuilder.AddForeignKey(
                name: "FK_FirstAids_Fish_FishId",
                table: "FirstAids",
                column: "FishId",
                principalTable: "Fish",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FirstAids_Fish_FishId",
                table: "FirstAids");

            migrationBuilder.UpdateData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FishId", "ImageUrl" },
                values: new object[] { 17, "" });

            migrationBuilder.InsertData(
                table: "FirstAids",
                columns: new[] { "Id", "Description", "FishId", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 5, "Clean the wound and place it in hot water to reduce pain.", 9, "", "Ray Sting" },
                    { 6, "Stop bleeding using pressure and call emergency services immediately.", 11, "", "Shark Attack" },
                    { 7, "Clean the wound carefully and seek medical treatment.", 15, "", "Moray Eel Bite" }
                });

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/grouper.jpg");

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/kingfish.jpg");

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/barracuda.jpg");

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "/images/lionfish.jpg");

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "/images/stonefish.jpg");

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BreedingSeason", "Description", "ImageUrl", "Locations", "MaxAge", "MaxSize", "Name" },
                values: new object[] { "Summer", "سمكة تجارية مهمة جدًا.", "/images/tuna.jpg", "Red Sea", "8 years", "2 meters", "Yellowfin Tuna (التونة الصفراء)" });

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BreedingSeason", "CategoryId", "Description", "ImageUrl", "IsDangerous", "IsEdible", "Locations", "MaxAge", "MaxSize", "Name", "Prevention" },
                values: new object[] { "Winter", 1, "من أشهر أسماك الخليج العربي.", "/images/hamour.jpg", false, true, "Arabian Gulf", "15 years", "1.2 meters", "Hamour (هامور الخليج)", "No risk" });

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BreedingSeason", "CategoryId", "Description", "ImageUrl", "IsDangerous", "IsEdible", "Locations", "MaxSize", "Name", "Prevention" },
                values: new object[] { "Summer", 2, "سمكة سامة جدًا تحتوي على سم قاتل.", "/images/pufferfish.jpg", true, false, "Red Sea & Arabian Gulf", "60 cm", "Pufferfish (سمكة النفاخ)", "Do not eat or touch" });

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BreedingSeason", "Description", "ImageUrl", "MaxAge", "MaxSize", "Name", "Prevention" },
                values: new object[] { "Spring", "كائن بحري يعيش في القاع وذيله قد يكون سام.", "/images/eagleray.jpg", "15 years", "3 meters", "Eagle Ray (اللخمة)", "Avoid touching" });

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "MaxAge", "MaxSize", "Name" },
                values: new object[] { "سمكة سريعة تعيش في أسراب.", "/images/mackerel.jpg", "10 years", "50 cm", "Mackerel (الماكريل)" });

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "IsDangerous", "IsEdible", "MaxAge", "MaxSize", "Name", "Prevention" },
                values: new object[] { 2, "من أشهر المفترسات البحرية في العالم.", "/images/shark.jpg", true, false, "30 years", "6 meters", "Shark (القرش)", "Avoid deep water swimming" });

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BreedingSeason", "Description", "ImageUrl", "IsEdible", "Locations", "MaxAge", "MaxSize", "Name" },
                values: new object[] { "Spring", "سمكة صغيرة تعيش في مجموعات كبيرة.", "/images/sardine.jpg", true, "Arabian Gulf", "5 years", "30 cm", "Sardine (السردين)" });

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageUrl", "IsEdible", "Locations", "MaxAge", "MaxSize", "Name", "Prevention" },
                values: new object[] { "سمكة ملونة تعيش قرب الشعاب المرجانية.", "/images/parrotfish.jpg", true, "Red Sea", "7 years", "1 meter", "Parrotfish (سمكة الببغاء)", "No risk" });

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BreedingSeason", "CategoryId", "Description", "ImageUrl", "IsDangerous", "MaxAge", "MaxSize", "Name", "Prevention" },
                values: new object[] { "All year", 1, "سمكة صغيرة تعيش بين شقائق النعمان البحرية.", "/images/clownfish.jpg", false, "6 years", "15 cm", "Clownfish (سمكة المهرج)", "No risk" });

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "IsDangerous", "IsEdible", "Locations", "MaxAge", "MaxSize", "Name", "Prevention" },
                values: new object[] { 2, "كائن بحري قد يهاجم عند الاقتراب منه.", "/images/eel.jpg", true, false, "Red Sea", "20 years", "4 meters", "Moray Eel (ثعبان البحر)", "Do not approach reefs" });

            migrationBuilder.UpdateData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ImageUrl", "IsEdible", "Locations", "MaxAge", "MaxSize", "Name", "Prevention" },
                values: new object[] { "كائن بحري يعيش لفترات طويلة.", "/images/turtle.jpg", false, "Red Sea & Arabian Gulf", "80 years", "1.5 meters", "Sea Turtle (السلحفاة البحرية)", "Protected species" });

            migrationBuilder.InsertData(
                table: "Fish",
                columns: new[] { "Id", "BreedingSeason", "CategoryId", "Description", "ImageUrl", "IsDangerous", "IsEdible", "Locations", "MaxAge", "MaxSize", "Name", "Prevention" },
                values: new object[,]
                {
                    { 17, "Summer", 2, "كائن بحري لاسع قد يسبب ألم شديد.", "/images/jellyfish.jpg", true, false, "Red Sea", "1 year", "40 cm", "Jellyfish (قنديل البحر)", "Avoid touching" },
                    { 18, "Spring", 1, "رخوي بحري سريع الحركة ويستخدم الحبر للدفاع.", "/images/cuttlefish.jpg", false, true, "Arabian Gulf", "2 years", "50 cm", "Cuttlefish (الحبار)", "No risk" },
                    { 19, "Summer", 1, "من القشريات البحرية المنتشرة بالخليج.", "/images/crab.jpg", false, true, "Arabian Gulf", "4 years", "25 cm", "Blue Crab (السلطعون الأزرق)", "Watch for claws" },
                    { 20, "Summer", 2, "ثعبان بحري سام يعيش في المياه الدافئة.", "/images/seasnake.jpg", true, false, "Red Sea", "10 years", "2 meters", "Sea Snake (ثعبان البحر السام)", "Do not approach" }
                });

            migrationBuilder.InsertData(
                table: "FirstAids",
                columns: new[] { "Id", "Description", "FishId", "ImageUrl", "Title" },
                values: new object[] { 9, "Keep the person calm and seek emergency medical care immediately.", 20, "", "Sea Snake Bite" });

            migrationBuilder.AddForeignKey(
                name: "FK_FirstAids_Fish_FishId",
                table: "FirstAids",
                column: "FishId",
                principalTable: "Fish",
                principalColumn: "Id");
        }
    }
}
