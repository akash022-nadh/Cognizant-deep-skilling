using Microsoft.EntityFrameworkCore;

public class InventoryContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=(localdb)\\mssqllocaldb;Database=InventoryDB;Trusted_Connection=True;"
        );
    }
}
