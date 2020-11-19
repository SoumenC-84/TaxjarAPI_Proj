using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Taxjar;
using TaxAPI;
namespace TaxCalculator_Demo.Controllers
{
    public class HomeController : Controller
    {

        TaxJarCommon obj = new TaxJarCommon();
        public ActionResult Index()
        {

            Taxjar.RateResponseAttributes dataObj= obj.GetTaxReateForaLocation();
            obj.CalculateTaxRate();
            return View();
        }
      
      
    }
}