using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using GAX.Core.Business.Interfaces;
using GAX.Core.Data;
using GAX.Core.Models;
using GAX.Core.Models.Base;

namespace GAX.Core.Business
{
    public class SupplierManager : ISupplierManager
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
            supplier.DateInserted = DateTime.Now;
            supplier.DateUpdeted = DateTime.Now;
            _db.Suppliers.Add(supplier);
            return _db.SaveChanges();
        }

        public int UpdateSupplier(Supplier supplier)
        {
            supplier.DateUpdeted = DateTime.Now;
            _db.Entry(supplier).State = EntityState.Modified;
            return _db.SaveChanges();
        }

        public int DeleteSupplier(int id)
        {
            var supplier = _db.Suppliers.Find(id);
            supplier.IsActive = false;
            //_db.Suppliers.Remove(supplier);
            //return _db.SaveChanges();
            return UpdateSupplier(supplier);
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}