using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using GAX.Core.Models;

namespace GAX.Core.Data
{
  public class SampleData : DropCreateDatabaseIfModelChanges<GaxEntities>
  {
    protected override void Seed(GaxEntities context)
    {
      var suppliers = new List<Supplier>
            {
                new Supplier { Name = "Moretti", IsActive = true},
                new Supplier { Name = "Barilla", IsActive = true},
                new Supplier { Name = "Findus", IsActive = true },
            };

      new List<Product>
        {
          new Product { Name="Birra", Supplier = suppliers.SingleOrDefault( s => s.Name == "Moretti")},
          new Product { Name="Pasta", Supplier = suppliers.SingleOrDefault( s => s.Name == "Barilla")},
          new Product { Name="Bastoncini di pesce", Supplier = suppliers.SingleOrDefault( s => s.Name == "Findus")},
          new Product { Name="Netbook", Supplier = suppliers.SingleOrDefault( s => s.Name == "Asus")}
        }.ForEach(p => context.Products.Add(p));

      new List<SiteSection>
        {
          new SiteSection { Name="Suppliers", Description = "Show/manage all suppliers", Enabled=true, ControllerName = "Supplier", ActionName="Index"},
          new SiteSection { Name="Products", Description = "Show/manage all products", Enabled=true, ControllerName = "Product", ActionName="Index"}
        }.ForEach(s => context.SiteSections.Add(s));
    }
  }
}