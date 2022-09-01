using Microsoft.EntityFrameworkCore;

public class Context : DbContext {

public DbSet<Tbl_Address> Tbl_Addresses {get; set;}

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.;Database=dbAddress;Trusted_Connection=True;");
    }

}