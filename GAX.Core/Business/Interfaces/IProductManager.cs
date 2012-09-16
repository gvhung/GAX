using System;
using System.Collections.Generic;
using GAX.Core.Models;

namespace GAX.Core.Business.Interfaces
{
  public interface IProductManager : IDisposable
  {
    IEnumerable<Product> GetProducts();
    Product GetProductById(int id);
    int AddProduct(Product product);
    int UpdateProduct(Product product);
    int DeleteProduct(int id);
  }
}
