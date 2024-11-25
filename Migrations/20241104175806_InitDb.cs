using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodReggie_1.Migrations
{
    /// <inheritdoc />
    public partial class InitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    FoodGroup = table.Column<string>(type: "TEXT", nullable: true),
                    Calories = table.Column<int>(type: "INTEGER", nullable: false),
                    Protein = table.Column<double>(type: "REAL", nullable: false),
                    Carbohydrates = table.Column<double>(type: "REAL", nullable: false),
                    Fats = table.Column<double>(type: "REAL", nullable: false),
                    ImageURL = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");
        }
    }
}
