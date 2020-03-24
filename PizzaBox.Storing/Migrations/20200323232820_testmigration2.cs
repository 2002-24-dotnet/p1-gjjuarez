using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class testmigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "Id",
                keyValue: 637205845546428471L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "Id",
                keyValue: 637205845546453156L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "Id",
                keyValue: 637205845546453285L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "Id",
                keyValue: 637205845546453301L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "Id",
                keyValue: 637205845546453313L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 637205845546473312L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 637205845546473979L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 637205845546474003L);

            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 637205845546482583L);

            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 637205845546483797L);

            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 637205845546483845L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205845546474791L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205845546475133L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205845546475160L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205845546475163L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205845546475166L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205845546475169L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205845546475172L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205845546475176L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205845546475179L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205845546475182L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205845546475184L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205845546475187L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205845546475190L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205845546475194L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205845546475197L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205845546475200L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205845546475205L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205845546475208L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205845546475210L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205845546475213L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205845546475216L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205845546475219L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205845546475222L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 637205845546476358L);

            migrationBuilder.InsertData(
                table: "Crust",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 637205848995357348L, "Stuffed Crust", 3.00m },
                    { 637205848995394045L, "Hand Tossed", 1.00m },
                    { 637205848995394157L, "Deep Dish", 2.00m }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 637205848995423416L, "Large", 17.95m },
                    { 637205848995424190L, "Regular", 12.95m },
                    { 637205848995424240L, "Small", 9.95m }
                });

            migrationBuilder.InsertData(
                table: "Store",
                columns: new[] { "Id", "Address", "Name", "Password", "Username" },
                values: new object[,]
                {
                    { 637205848995434103L, "12345 Streat st, Arlington, Texas", "Dominos", "Password1", "store1" },
                    { 637205848995435302L, "12346 Streat st, Arlington, Texas", "Papa Johns", "Password2", "store2" }
                });

            migrationBuilder.InsertData(
                table: "Topping",
                columns: new[] { "Id", "Name", "Price", "ToppingType" },
                values: new object[,]
                {
                    { 637205848995425662L, "Mozzarella Cheese", 0.25m, 0 },
                    { 637205848995426255L, "Parmesan Cheese", 0.50m, 0 },
                    { 637205848995426332L, "Tomato Sauce", 0.25m, 1 },
                    { 637205848995426338L, "Pepperoni", 1.00m, 2 },
                    { 637205848995426350L, "Ham", 1.50m, 2 },
                    { 637205848995426361L, "Beef", 1.50m, 2 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Name", "Password", "Username" },
                values: new object[] { 637205848995430188L, "George", "Password12345", "George" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "Id",
                keyValue: 637205848995357348L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "Id",
                keyValue: 637205848995394045L);

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "Id",
                keyValue: 637205848995394157L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 637205848995423416L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 637205848995424190L);

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 637205848995424240L);

            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 637205848995434103L);

            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 637205848995435302L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205848995425662L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205848995426255L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205848995426332L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205848995426338L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205848995426350L);

            migrationBuilder.DeleteData(
                table: "Topping",
                keyColumn: "Id",
                keyValue: 637205848995426361L);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 637205848995430188L);

            migrationBuilder.InsertData(
                table: "Crust",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 637205845546428471L, "Crunchy Thin Crust", 1.00m },
                    { 637205845546453156L, "Hand Tossed", 1.00m },
                    { 637205845546453285L, "Multigrain", 1.00m },
                    { 637205845546453301L, "Stuffed Crust", 3.00m },
                    { 637205845546453313L, "Deep Dish", 2.00m }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 637205845546473312L, "Large", 17.95m },
                    { 637205845546473979L, "Regular", 12.95m },
                    { 637205845546474003L, "Small", 9.95m }
                });

            migrationBuilder.InsertData(
                table: "Store",
                columns: new[] { "Id", "Address", "Name", "Password", "Username" },
                values: new object[,]
                {
                    { 637205845546483797L, "12346 Streat st, Arlington, Texas", "Worst Pizza", "Password2", "store2" },
                    { 637205845546483845L, "12347 Streat st, Arlington, Texase", "Pizzeria", "Password3", "store3" },
                    { 637205845546482583L, "12345 Streat st, Arlington, Texas", "Best Pizza", "Password1", "store1" }
                });

            migrationBuilder.InsertData(
                table: "Topping",
                columns: new[] { "Id", "Name", "Price", "ToppingType" },
                values: new object[,]
                {
                    { 637205845546475190L, "Grilled Chicken", 3.00m, 2 },
                    { 637205845546475219L, "Red Onion", 0.75m, 3 },
                    { 637205845546475216L, "Olives", 0.75m, 3 },
                    { 637205845546475213L, "Mushrooms", 0.75m, 3 },
                    { 637205845546475210L, "Marinated Tomatoes", 0.75m, 3 },
                    { 637205845546475208L, "Tomato", 0.75m, 3 },
                    { 637205845546475205L, "Jalapeno", 0.75m, 3 },
                    { 637205845546475200L, "Hot Peppers", 0.75m, 3 },
                    { 637205845546475197L, "Green Pepper", 0.75m, 3 },
                    { 637205845546475194L, "Pineapple", 0.75m, 2 },
                    { 637205845546475187L, "Bacon Crumble", 2.00m, 2 },
                    { 637205845546475172L, "Pepperoni", 1.00m, 2 },
                    { 637205845546475182L, "Ham", 1.50m, 2 },
                    { 637205845546475179L, "Mild Sausage", 1.50m, 2 },
                    { 637205845546475176L, "Italian Sausage", 1.50m, 2 },
                    { 637205845546475222L, "Roasted Red Pepper", 0.75m, 3 },
                    { 637205845546475169L, "Pesto Sauce", 1.00m, 1 },
                    { 637205845546475166L, "Alfredo Sauce", 0.50m, 1 },
                    { 637205845546475163L, "Tomato Sauce", 0.25m, 1 },
                    { 637205845546475160L, "Feta Cheese", 0.75m, 0 },
                    { 637205845546475133L, "Parmesan Cheese", 0.50m, 0 },
                    { 637205845546474791L, "Mozzarella Cheese", 0.25m, 0 },
                    { 637205845546475184L, "Beef", 1.50m, 2 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Name", "Password", "Username" },
                values: new object[] { 637205845546476358L, "Jesus", "Password12345", "jesus" });
        }
    }
}
