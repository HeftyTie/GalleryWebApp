using ArtPavillion.DatabaseContext.Models;
using Microsoft.EntityFrameworkCore;

namespace ArtPavillion.DatabaseContext;
public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Images> Images { get; set; }
}
