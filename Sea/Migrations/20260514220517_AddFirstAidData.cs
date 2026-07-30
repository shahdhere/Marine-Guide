using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sea.Migrations
{
    /// <inheritdoc />
    public partial class AddFirstAidData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FirstAids",
                columns: new[] { "Id", "Description", "FishId", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 1, "Wash the wound with clean water, stop bleeding, and seek medical help immediately.", 3, "", "Barracuda Bite" },
                    { 2, "Place the injured area in hot water for 30-90 minutes and go to the hospital.", 4, "", "Lionfish Sting" },
                    { 3, "Call emergency services immediately and soak the wound in hot water.", 5, "", "Stonefish Sting" },
                    { 4, "Call emergency services immediately. Do not wait for symptoms.", 8, "", "Pufferfish Poisoning" },
                    { 5, "Clean the wound and place it in hot water to reduce pain.", 9, "", "Ray Sting" },
                    { 6, "Stop bleeding using pressure and call emergency services immediately.", 11, "", "Shark Attack" },
                    { 7, "Clean the wound carefully and seek medical treatment.", 15, "", "Moray Eel Bite" },
                    { 8, "Rinse with seawater and use vinegar if available. Do not rub the skin.", 17, "", "Jellyfish Sting" },
                    { 9, "Keep the person calm and seek emergency medical care immediately.", 20, "", "Sea Snake Bite" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 4);

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
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FirstAids",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
