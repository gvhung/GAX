using System.Collections.Generic;
using System.Linq;
using GAX.Core.Business.Interfaces;
using GAX.Core.Data;
using GAX.Core.Models;

namespace GAX.Core.Business
{
  public class StoreManager : IStoreManager
  {
    GaxEntities _db = new GaxEntities();

    public IEnumerable<Supplier> GetAllSuppliers()
    {
      return _db.Suppliers.AsEnumerable();
    }
  }
}