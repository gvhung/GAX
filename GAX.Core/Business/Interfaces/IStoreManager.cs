using System.Collections.Generic;
using GAX.Core.Models;

namespace GAX.Core.Business.Interfaces
{
  public interface IStoreManager
  {
    IEnumerable<Supplier> GetAllSuppliers();
  }
}
