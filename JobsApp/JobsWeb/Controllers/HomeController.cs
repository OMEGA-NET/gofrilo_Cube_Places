using JobsWeb.Models;
using JobsWeb.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace JobsWeb.Controllers
{
    public class HomeController : Controller
    {
        Global _global = new Global();

        public ActionResult Index()
        {
            List<Product> objProduct = null;
            var hCliente = _global.rspClientGET("Product/");

            if (hCliente.IsSuccessStatusCode)
            {
                objProduct = new JavaScriptSerializer().Deserialize<List<Product>>(hCliente.Content.ReadAsStringAsync().Result);
            }
            return View(objProduct);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}