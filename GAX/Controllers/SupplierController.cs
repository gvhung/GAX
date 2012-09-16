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
  public class SupplierController : Controller
  {
    private readonly ISupplierManager _store;

    public SupplierController(ISupplierManager store)
    {
      _store = store;
    }

    //
    // GET: /Supplier/

    public ViewResult Index()
    {
      var suppliers = _store.GetSuppliers();
      return View(suppliers);
    }

    //
    // GET: /Supplier/Details/5

    public ViewResult Details(int id)
    {
      var supplier = _store.GetSupplierById(id);
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
    public ActionResult Create(Supplier supplier)
    {
      if (ModelState.IsValid)
      {
        _store.AddSupplier(supplier);
        return RedirectToAction("Index");
      }

      return View(supplier);
    }

    //
    // GET: /Supplier/Edit/5

    public ActionResult Edit(int id)
    {
      var supplier = _store.GetSupplierById(id);
      return View(supplier);
    }

    //
    // POST: /Supplier/Edit/5

    [HttpPost]
    public ActionResult Edit(Supplier supplier)
    {
      if (ModelState.IsValid)
      {
        _store.UpdateSupplier(supplier);
        return RedirectToAction("Index");
      }
      return View(supplier);
    }

    //
    // GET: /Supplier/Delete/5

    public ActionResult Delete(int id)
    {
      var supplier = _store.GetSupplierById(id);
      return View(supplier);
    }

    //
    // POST: /Supplier/Delete/5

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      _store.DeleteSupplier(id);
      return RedirectToAction("Index");
    }

    protected override void Dispose(bool disposing)
    {
      _store.Dispose();
      base.Dispose(disposing);
    }
  }
}