using Euro.Models;
using Microsoft.EntityFrameworkCore;


namespace Euro.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Tłumiki", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Uchwyty", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Uszczelki", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Uniwersalny tłumik epliptyczny E113", Description = "Uniwersalny tłumik przelotowy ze stali kwasoodpornej.\nDługość puszki tłumika - 400 mm\nSzerokość/wysokość puszki tłumika - 220/130 mm\nDługość końcówki - 250 mm\nŚrednica końcówki - 89 mm\nŚrednica rury dolotowej - 50, 60, 63,5 , 70, 76 mm\nProdukt dostępny również w wersji z przetłoczeniem wewnątrz przelotu poprawiającym tłumienie.", Producent = "RM MOTORS", SerialNumber = "E113", ListPrice = 750, CategoryId = 1, ImageURL = "" },
                new Product { Id = 2, Name = "Tłumik przelotowy z zaworem podciśnieniowym E400", Description = "Tłumik ze stali kwasoodpornej z wbudowaną przepustnicą\n\nTyp zaworu - Podciśnieniowy\nWysokość/szerokość puszki - 130x220 mm\nŚrednica dolotu - 63,5 / 76 mm", Producent = "RM MOTORS", SerialNumber = "E400", ListPrice = 1500, CategoryId = 1, ImageURL = "" },
                new Product { Id = 3, Name = "Poprzeczny tłumik przelotowy z zaworem elektrycznym E600", Description = "Tłumik ze stali kwasoodpornej z wbudowaną przepustnicą\n\nTyp zaworu - Elektryczny\nWysokość/szerokość tłumika - 130x220 mm\nDługość puszki - 350 mm\nDługość całkowita - 740 mm", Producent = "RM MOTORS", SerialNumber = "E600", ListPrice = 2933, CategoryId = 1, ImageURL = "" },
                new Product { Id = 4, Name = "Wieszak wydechu tłumika Czerwony FigerSPEC", Description = "Sportowy wieszak tłumika wydechu, wykonany z twardszej mieszanki gumy zapewnia pewne trzymanie ograniczając ruchy układu wydechowego. Dzięki idealnie dobranej twardości nie wpływa na komfort użytkowania pojazdu.\n\nŚrednica otworów: 11mm\nDługość całkowita: 73mm\nSzerokość: 47mm\nWysokość: 21mm", Producent = "FigerSPEC", SerialNumber = "FG-WS-RED", ListPrice = 10, CategoryId = 2, ImageURL = "" },
                new Product { Id = 5, Name = "Wieszak wydechu tłumika XL Czerwony FigerSPEC", Description = "Sportowy wieszak tłumika wydechu, wykonany z twardszej mieszanki gumy zapewnia pewne trzymanie ograniczając ruchy układu wydechowego. Dzięki idealnie dobranej twardości nie wpływa na komfort użytkowania pojazdu.\n\nŚrednica otworów: 11mm\nDługość całkowita: 108mm\nSzerokość: 44mm\nWysokość: 20mm", Producent = "FigerSPEC", SerialNumber = "FG-WSXL-RED", ListPrice = 13.99, CategoryId = 2, ImageURL = "" },
                new Product { Id = 6, Name = "Uszczelka, rura wylotowa JP GROUP 1121101500", Description = "Uszczelka rury wydechowej", Producent = "JP-Group Automotive", SerialNumber = "1121101500 ", ListPrice = 8.99, CategoryId = 3, ImageURL = "" }
                );

        }
    }
}
