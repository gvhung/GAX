using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GAX.Core.Business;
using GAX.Core.Business.Interfaces;

namespace GAX.Controllers
{
  //[Authorize(Roles = "Administrator")]
  public class SupplierController : Controller
  {
    private readonly IStoreManager _store;

    public SupplierController(IStoreManager store)
    {
      _store = store;
    }

    //
    // GET: /Supplier/Index

    public ActionResult Index()
    {
      return View(_store.GetAllSuppliers());
    }

  }
}
