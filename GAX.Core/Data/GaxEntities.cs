using System.Data.Entity;
using GAX.Core.Models;

namespace GAX.Core.Data
{
  public class GaxEntities : DbContext
  {
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<SiteSection> SiteSections { get; set; }
  }
}