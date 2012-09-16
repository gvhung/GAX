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
    public class ProductManager : IProductManager
    {
        private readonly GaxEntities _db = new GaxEntities();

        public IEnumerable<Product> GetProducts()
        {
            return _db.Products.Where(s => s.IsActive);
        }

        public Product GetProductById(int id)
        {
            return _db.Products.Find(id);
        }

        public int AddProduct(Product Product)
        {
            Product.DateInserted = DateTime.Now;
            Product.DateUpdeted = DateTime.Now;
            _db.Products.Add(Product);
            return _db.SaveChanges();
        }

        public int UpdateProduct(Product product)
        {
            product.DateUpdeted = DateTime.Now;
            _db.Entry(product).State = EntityState.Modified;
            return _db.SaveChanges();
        }

        public int DeleteProduct(int id)
        {
            var product = _db.Products.Find(id);
            product.IsActive = false;
            //_db.Products.Remove(product);
            //return _db.SaveChanges();
            return UpdateProduct(product);
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}