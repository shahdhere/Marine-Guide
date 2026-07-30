using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sea.Migrations
{
    /// <inheritdoc />
    public partial class SeedDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FirstAid_Fish_FishId",
                table: "FirstAid");

            migrationBuilder.DropForeignKey(
                name: "FK_Fish_Category_CategoryId",
                table: "Fish");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FirstAid",
                table: "FirstAid");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "FirstAid",
                newName: "FirstAids");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_FirstAid_FishId",
                table: "FirstAids",
                newName: "IX_FirstAids_FishId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FirstAids",
                table: "FirstAids",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "جميع الأسماك البحرية الموجودة في المياه السعودية", "/images/fish-category.jpg", "Fish" },
                    { 2, "الكائنات البحرية الضارة أو السامة التي يجب الحذر منها", "/images/dangerous-category.jpg", "Dangerous" }
                });

            migrationBuilder.InsertData(
                table: "Fish",
                columns: new[] { "Id", "BreedingSeason", "CategoryId", "Description", "ImageUrl", "IsDangerous", "IsEdible", "Locations", "MaxAge", "MaxSize", "Name", "Prevention" },
                values: new object[,]
                {
                    { 1, "Summer", 1, "من أشهر أسماك البحر الأحمر ويؤكل بكثرة.", "/images/grouper.jpg", false, true, "Red Sea & Arabian Gulf", "20 years", "1 meter", "Red Sea Grouper (الهامور)", "No risk" },
                    { 2, "Spring", 1, "سمكة سريعة ومهمة اقتصاديًا في السعودية.", "/images/kingfish.jpg", false, true, "Red Sea & Arabian Gulf", "20 years", "2 meters", "Kingfish (الكنعد)", "No risk" },
                    { 3, "Summer", 2, "مفترس بحري سريع وقد يكون خطير.", "/images/barracuda.jpg", true, false, "Red Sea", "14 years", "1.5 meters", "Barracuda (الباراكودا)", "Avoid swimming near it" },
                    { 4, "All year", 2, "سمكة سامة ذات أشواك خطيرة.", "/images/lionfish.jpg", true, false, "Red Sea", "10 years", "40 cm", "Lionfish (سمكة الأسد)", "Do not touch" },
                    { 5, "Spring", 2, "أخطر سمكة سامة في العالم.", "/images/stonefish.jpg", true, false, "Red Sea", "10 years", "50 cm", "Stonefish (سمكة الحجر)", "Avoid stepping on rocks" },
                    { 6, "Summer", 1, "سمكة تجارية مهمة جدًا.", "/images/tuna.jpg", false, true, "Red Sea", "8 years", "2 meters", "Yellowfin Tuna (التونة الصفراء)", "No risk" },
                    { 7, "Winter", 1, "من أشهر أسماك الخليج العربي.", "/images/hamour.jpg", false, true, "Arabian Gulf", "15 years", "1.2 meters", "Hamour (هامور الخليج)", "No risk" },
                    { 8, "Summer", 2, "سمكة سامة جدًا تحتوي على سم قاتل.", "/images/pufferfish.jpg", true, false, "Red Sea & Arabian Gulf", "10 years", "60 cm", "Pufferfish (سمكة النفاخ)", "Do not eat or touch" },
                    { 9, "Spring", 2, "كائن بحري يعيش في القاع وذيله قد يكون سام.", "/images/eagleray.jpg", true, false, "Red Sea", "15 years", "3 meters", "Eagle Ray (اللخمة)", "Avoid touching" },
                    { 10, "Spring", 1, "سمكة سريعة تعيش في أسراب.", "/images/mackerel.jpg", false, true, "Arabian Gulf", "10 years", "50 cm", "Mackerel (الماكريل)", "No risk" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_FirstAids_Fish_FishId",
                table: "FirstAids",
                column: "FishId",
                principalTable: "Fish",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fish_Categories_CategoryId",
                table: "Fish",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FirstAids_Fish_FishId",
                table: "FirstAids");

            migrationBuilder.DropForeignKey(
                name: "FK_Fish_Categories_CategoryId",
                table: "Fish");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FirstAids",
                table: "FirstAids");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Fish",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameTable(
                name: "FirstAids",
                newName: "FirstAid");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_FirstAids_FishId",
                table: "FirstAid",
                newName: "IX_FirstAid_FishId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FirstAid",
                table: "FirstAid",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FirstAid_Fish_FishId",
                table: "FirstAid",
                column: "FishId",
                principalTable: "Fish",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fish_Category_CategoryId",
                table: "Fish",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
