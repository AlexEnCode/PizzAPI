using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzAPI.Migrations
{
    public partial class newmi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pizza",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(37,2)", precision: 37, scale: 2, nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isVegetarian = table.Column<bool>(type: "bit", nullable: false),
                    isSpicy = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pizza", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PizzaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.id);
                    table.ForeignKey(
                        name: "FK_Ingredient_pizza_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "pizza",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "id", "description", "name", "PizzaId" },
                values: new object[,]
                {
                    { 1, "Freshly made tomato sauce", "Tomato sauce", 0 },
                    { 2, "High-quality mozzarella cheese", "Mozzarella cheese", 0 },
                    { 3, "Fresh basil leaves", "Basil", 0 },
                    { 4, "Spicy pepperoni slices", "Pepperoni", 0 },
                    { 5, "Fresh sliced mushrooms", "Mushrooms", 0 },
                    { 6, "Assorted bell peppers", "Bell peppers", 0 },
                    { 7, "Sliced onions", "Onions", 0 }
                });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "Email", "firstname", "IsAdmin", "lastname", "Password" },
                values: new object[,]
                {
                    { 1, "john.doe@example.com", "John", false, "Doe", "StrongPassword123!" },
                    { 2, "alice.smith@example.com", "Alice", true, "Smith", "SecurePass789!" },
                    { 3, "emma.johnson@example.com", "Emma", false, "Johnson", "Secret1234!" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_PizzaId",
                table: "Ingredient",
                column: "PizzaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "pizza");
        }
    }
}
