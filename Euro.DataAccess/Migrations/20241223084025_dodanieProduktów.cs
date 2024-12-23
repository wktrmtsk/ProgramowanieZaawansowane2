using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Euro.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class dodanieProduktów : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Producent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ListPrice", "Name", "Producent", "SerialNumber" },
                values: new object[,]
                {
                    { 1, "Uniwersalny tłumik przelotowy ze stali kwasoodpornej.\nDługość puszki tłumika - 400 mm\nSzerokość/wysokość puszki tłumika - 220/130 mm\nDługość końcówki - 250 mm\nŚrednica końcówki - 89 mm\nŚrednica rury dolotowej - 50, 60, 63,5 , 70, 76 mm\nProdukt dostępny również w wersji z przetłoczeniem wewnątrz przelotu poprawiającym tłumienie.", 750.0, "Uniwersalny tłumik epliptyczny E113", "RM MOTORS", "E113" },
                    { 2, "Tłumik ze stali kwasoodpornej z wbudowaną przepustnicą\n\nTyp zaworu - Podciśnieniowy\nWysokość/szerokość puszki - 130x220 mm\nŚrednica dolotu - 63,5 / 76 mm", 1500.0, "Tłumik przelotowy z zaworem podciśnieniowym E400", "RM MOTORS", "E400" },
                    { 3, "Tłumik ze stali kwasoodpornej z wbudowaną przepustnicą\n\nTyp zaworu - Elektryczny\nWysokość/szerokość tłumika - 130x220 mm\nDługość puszki - 350 mm\nDługość całkowita - 740 mm", 2933.0, "Poprzeczny tłumik przelotowy z zaworem elektrycznym E600", "RM MOTORS", "E600" },
                    { 4, "Sportowy wieszak tłumika wydechu, wykonany z twardszej mieszanki gumy zapewnia pewne trzymanie ograniczając ruchy układu wydechowego. Dzięki idealnie dobranej twardości nie wpływa na komfort użytkowania pojazdu.\n\nŚrednica otworów: 11mm\nDługość całkowita: 73mm\nSzerokość: 47mm\nWysokość: 21mm", 10.0, "Wieszak wydechu tłumika Czerwony FigerSPEC", "FigerSPEC", "FG-WS-RED" },
                    { 5, "Sportowy wieszak tłumika wydechu, wykonany z twardszej mieszanki gumy zapewnia pewne trzymanie ograniczając ruchy układu wydechowego. Dzięki idealnie dobranej twardości nie wpływa na komfort użytkowania pojazdu.\n\nŚrednica otworów: 11mm\nDługość całkowita: 108mm\nSzerokość: 44mm\nWysokość: 20mm", 13.99, "Wieszak wydechu tłumika XL Czerwony FigerSPEC", "FigerSPEC", "FG-WSXL-RED" },
                    { 6, "Uszczelka rury wydechowej", 8.9900000000000002, "Uszczelka, rura wylotowa JP GROUP 1121101500", "JP-Group Automotive", "1121101500 " }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
