using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using GAX.Core.Business.Interfaces;
using GAX.Core.Data;
using GAX.Core.Models;

namespace GAX.Core.Business
{
  public class StoreManager : IStoreManager
  {
    private readonly GaxEntities _db = new GaxEntities();

    public IEnumerable<Supplier> GetSuppliers()
    {
      return _db.Suppliers.Where(s => s.IsActive);
    }

    public Supplier GetSupplierById(int id)
    {
      return _db.Suppliers.Find(id);
    }

    public int AddSupplier(Supplier supplier)
    {
      _db.Suppliers.Add(supplier);
      return _db.SaveChanges();
    }

    public int UpdateSupplier(Supplier supplier)
    {
      _db.Entry(supplier).State = EntityState.Modified;
      return _db.SaveChanges();
    }

    public int DeleteSupplier(int id)
    {
      var supplier = _db.Suppliers.Find(id);
      _db.Suppliers.Remove(supplier);
      return _db.SaveChanges();
    }

    public void Dispose()
    {
      _db.Dispose();
    }
  }
}