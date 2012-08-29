using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GAX.Core.Business;
using GAX.Core.Business.Interfaces;

namespace GAX.Controllers
{
  public class HomeController : Controller
  {
    private readonly ISiteManager _siteManager;


    public HomeController(ISiteManager siteManager)
    {
      _siteManager = siteManager;
    }

    //
    // GET: /Home/Index

    public ActionResult Index()
    {
      ViewBag.Message = "Welcome to GAX!";
      var allSections = _siteManager.GetActiveSections();

      return View(allSections);
    }

    //
    // GET: /Home/About

    public ActionResult About()
    {
      return View();
    }
  }
}
