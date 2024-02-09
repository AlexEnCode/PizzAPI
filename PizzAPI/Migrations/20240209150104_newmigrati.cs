using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzAPI.Migrations
{
    public partial class newmigrati : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IngredientPizza",
                columns: table => new
                {
                    pizza_id = table.Column<int>(type: "int", nullable: false),
                    ingredient_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientPizza", x => new { x.pizza_id, x.ingredient_id });
                    table.ForeignKey(
                        name: "FK_IngredientPizza_Ingredient_ingredient_id",
                        column: x => x.ingredient_id,
                        principalTable: "Ingredient",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientPizza_pizza_pizza_id",
                        column: x => x.pizza_id,
                        principalTable: "pizza",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "pizza",
                columns: new[] { "id", "description", "image", "isSpicy", "isVegetarian", "name", "price" },
                values: new object[] { 1, "Tomato sauce, mozzarella cheese, basil", "margherita.jpg", false, true, "Margherita", 9.99m });

            migrationBuilder.InsertData(
                table: "pizza",
                columns: new[] { "id", "description", "image", "isSpicy", "isVegetarian", "name", "price" },
                values: new object[] { 2, "Tomato sauce, mozzarella cheese, pepperoni slices", "pepperoni.jpg", true, false, "Pepperoni", 11.99m });

            migrationBuilder.InsertData(
                table: "pizza",
                columns: new[] { "id", "description", "image", "isSpicy", "isVegetarian", "name", "price" },
                values: new object[] { 3, "Tomato sauce, mozzarella cheese, mushrooms, bell peppers, onions", "vegetarian_deluxe.jpg", false, true, "Vegetarian Deluxe", 12.99m });

            migrationBuilder.InsertData(
                table: "IngredientPizza",
                columns: new[] { "ingredient_id", "pizza_id" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "IngredientPizza",
                columns: new[] { "ingredient_id", "pizza_id" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "IngredientPizza",
                columns: new[] { "ingredient_id", "pizza_id" },
                values: new object[] { 1, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientPizza_ingredient_id",
                table: "IngredientPizza",
                column: "ingredient_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientPizza");

            migrationBuilder.DeleteData(
                table: "pizza",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "pizza",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "pizza",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
