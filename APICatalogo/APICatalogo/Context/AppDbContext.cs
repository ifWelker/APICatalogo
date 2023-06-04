using APICatalogo.Models;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
    {

    }

    public DbSet<Categorias>? Categorias { get; set; }
    public DbSet<Produtos>? Produtos { get; set; }
}
