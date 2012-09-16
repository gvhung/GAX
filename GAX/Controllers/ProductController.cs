using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GAX.Core.Business.Interfaces;
using GAX.Core.Models;
using GAX.Core.Data;

namespace GAX.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductManager _store;

        public ProductController(IProductManager store)
        {
            _store = store;
        }

        //
        // GET: /Supplier/

        public ViewResult Index()
        {
            var suppliers = _store.GetProducts();
            return View(suppliers);
        }

        //
        // GET: /Supplier/Details/5

        public ViewResult Details(int id)
        {
            var supplier = _store.GetProductById(id);
            return View(supplier);
        }

        //
        // GET: /Supplier/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Supplier/Create

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _store.AddProduct(product);
                return RedirectToAction("Index");
            }

            return View(product);
        }

        //
        // GET: /Supplier/Edit/5

        public ActionResult Edit(int id)
        {
            var product = _store.GetProductById(id);
            return View(product);
        }

        //
        // POST: /Supplier/Edit/5

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _store.UpdateProduct(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        //
        // GET: /Supplier/Delete/5

        public ActionResult Delete(int id)
        {
            var product = _store.GetProductById(id);
            return View(product);
        }

        //
        // POST: /Supplier/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            _store.DeleteProduct(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            _store.Dispose();
            base.Dispose(disposing);
        }
    }
}