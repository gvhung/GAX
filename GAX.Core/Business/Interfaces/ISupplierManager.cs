using System;
using System.Collections.Generic;
using GAX.Core.Models;

namespace GAX.Core.Business.Interfaces
{
  public interface ISupplierManager : IDisposable
  {
    IEnumerable<Supplier> GetSuppliers();
    Supplier GetSupplierById(int id);
    int AddSupplier(Supplier supplier);
    int UpdateSupplier(Supplier supplier);
    int DeleteSupplier(int id);
  }
}
