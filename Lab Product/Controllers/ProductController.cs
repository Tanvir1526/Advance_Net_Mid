using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab_Product.Models;
namespace Lab_Product.Controllers
{
    public class ProductController : Controller
    {

        
        public ActionResult List()
        {
            List<Product>products=new List<Product>();

            return View();
        }

    }
}