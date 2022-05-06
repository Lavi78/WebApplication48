using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication48.Models;

namespace WebApplication48.Controllers
{
    public class TigerController : Controller
    {
        Applicationdbcontext dbcontext = new Applicationdbcontext();
        // GET: Tiger
        public ActionResult Index()
        {
            List<Tiger> Tigers = dbcontext.Tigers.ToList();
            return View(Tigers);
        }
        public ActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Create(string Title, decimal Price, int Quantity, string descr)
        {
          
            Tiger tiger = new Tiger()
            {
                Title = Title,
                Price = Price,
                Quantity = Quantity,
                descr = descr
                

            };
            dbcontext.Tigers.Add(tiger);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}